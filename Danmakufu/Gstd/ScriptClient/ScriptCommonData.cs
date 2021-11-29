using System.Collections.Generic;
using Gstd.Script;
using Gstd.File;

namespace Gstd.ScriptClient
{
    sealed class ScriptCommonData
    {
        private SortedDictionary<string, Value> mapValue = new SortedDictionary<string, Value>();

        private Value _ReadRecord(ByteBuffer buffer)
        {
            ScriptTypeManager scriptTypeManager = ScriptClientBase.GetDefaultScriptTypeManager();
            Value res = new Value();
            TypeKind kind = (TypeKind)buffer.ReadInteger();

            if (kind == TypeKind.tk_real)
            {
                double data = buffer.ReadDouble();
                res = new Value(scriptTypeManager.RealType, data);
            }
            else if (kind == TypeKind.tk_char)
            {
                char data = buffer.ReadCharacter();
                res = new Value(scriptTypeManager.CharType, data);
            }
            else if (kind == TypeKind.tk_boolean)
            {
                bool data = buffer.ReadBoolean();
                res = new Value(scriptTypeManager.BooleanType, data);
            }
            else if (kind == TypeKind.tk_array)
            {
                int arrayLength = buffer.ReadInteger();
                Value v = new Value();
                for (int iArray = 0 ; iArray < arrayLength ; iArray++)
                {
                    Value arrayValue = _ReadRecord(buffer);
                    v.Append(scriptTypeManager.GetArrayType(arrayValue.GetDataType()), arrayValue);
                }
                res = v;
            }

            return res;
        }
        private void _WriteRecord(ByteBuffer buffer, Value comValue)
        {
            TypeKind kind = comValue.GetDataType().Kind;
            buffer.WriteInteger((int)kind);
            if (kind == TypeKind.tk_real)
            {
                buffer.WriteDouble(comValue.AsReal());
            }
            else if (kind == TypeKind.tk_char)
            {
                buffer.WriteCharacter(comValue.AsChar());
            }
            else if (kind == TypeKind.tk_boolean)
            {
                buffer.WriteBoolean(comValue.AsBoolean());
            }
            else if (kind == TypeKind.tk_array)
            {
                int arrayLength = (int)comValue.LengthAsArray();
                buffer.WriteInteger(arrayLength);

                for (int iArray = 0 ; iArray < arrayLength ; iArray++)
                {
                    Value arrayValue = comValue.IndexAsArray(iArray);
                    _WriteRecord(buffer, arrayValue);
                }
            }
        }
        public ScriptCommonData()
        {
        }
        public void Clear()
        {
            mapValue.Clear();
        }
        public bool IsExists(string name)
        {
            return mapValue.ContainsKey(name);
        }
        public Value GetValue(string name)
        {
            if (!IsExists(name))
            {
                return new Value();
            }
            return new Value(mapValue[name]);
        }
        public void SetValue(string name, Value v)
        {
            mapValue[name] = v;
        }
        public void DeleteValue(string name)
        {
            mapValue.Remove(name);
        }
        public void Copy(ScriptCommonData dataSrc)
        {
            mapValue.Clear();
            List<string> listSrcKey = dataSrc.GetKeyList();
            for (int iKey = 0 ; iKey < listSrcKey.Count ; iKey++)
            {
                string key = listSrcKey[iKey];
                Value vSrc = dataSrc.GetValue(key);
                Value vDest = vSrc;
                vDest.Unique();
                mapValue[key] = vDest;
            }
        }
        public List<string> GetKeyList()
        {
            List<string> res = new List<string>();
            SortedDictionary<string, Value>.Enumerator itrValue;
            for (itrValue = mapValue.GetEnumerator(); itrValue.MoveNext();)
            {
                string key = itrValue.Current.Key;
                res.Add(key);
            }
            return res;
        }

        /*public void ReadRecord(gstd::RecordBuffer& record);
        public void WriteRecord(gstd::RecordBuffer& record);*/
    }
}
