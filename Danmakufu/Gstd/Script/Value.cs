using System.Diagnostics;
using System.Text;
#if _TRACE_VALUE
using System;
#endif

namespace Gstd
{
    namespace Script
    {
        sealed class Value // TODO prevent pass TypeData
        {
#if _TRACE_VALUE
            static int counter = 0;
            public int id;
#endif
            private Body data;
            public Value()
            {
#if _TRACE_VALUE
                id = -1;
                data = null;
#endif
            }
            public Value(TypeData t, double v)
            {
                data = new Body();
                data.RefCount = 1;
                data.Type = t;
                data.RealValue = v;
#if _TRACE_VALUE
                id = counter++;
#endif
            }
            public Value(TypeData t, char v)
            {
                data = new Body();
                data.RefCount = 1;
                data.Type = t;
                data.CharValue = v;
#if _TRACE_VALUE
                id = counter++;
#endif
            }
            public Value(TypeData t, bool v)
            {
                data = new Body();
                data.RefCount = 1;
                data.Type = t;
                data.BooleanValue = v;
#if _TRACE_VALUE
                id = counter++;
#endif
            }
            public Value(TypeData t, string v)
            {
                data = new Body();
                data.RefCount = 1;
                data.Type = t;
                foreach (char ch in v.ToCharArray())
                {
                    data.ArrayValue.Add(new Value(t.Element, ch));
                }
#if _TRACE_VALUE
                id = counter++;
#endif
            }
            public Value(Value source)
            {
                data = source.data;
                if (data != null)
                {
                    ++(data.RefCount);
                }
#if _TRACE_VALUE
                id = 10000+source.id;
#endif
            }
            ~Value() // TODO remove
            {
                Release();
            }
#if _TRACE_VALUE
            private bool IsTarget()
            {
                return false;//id == 3;
            }
#endif
            public void Assign(Value source) // TODO use copy
            {
#if _TRACE_VALUE
                if (IsTarget() || source.IsTarget())
                {
                    Console.WriteLine("V:Assign this " + AsString());
                    Console.WriteLine("V:Assign source " + source.AsString());
                }
                id = source.id;
#endif
                if (source.data != null)
                {
                    ++(source.data.RefCount);
                }
                Release();
                data = source.data;
            }
            public bool HasData()
            {
                return data != null;
            }
            public void Set(TypeData t, double v)
            {
                Unique();
                data.Type = t;
                data.RealValue = v;
#if _TRACE_VALUE
                if (IsTarget())
                {
                    Console.WriteLine("V:set double " + AsString());
                }
#endif
            }
            public void Set(TypeData t, bool v)
            {
                Unique();
                data.Type = t;
                data.BooleanValue = v;
#if _TRACE_VALUE
                if (IsTarget())
                {
                    Console.WriteLine("V:set bool " + AsString());
                }
#endif
            }
            public void Append(TypeData t, Value x)
            {
                Unique();
                data.Type = t;
                data.ArrayValue.Add(x);
#if _TRACE_VALUE
                if (IsTarget())
                {
                    Console.WriteLine("V:Append " + AsString());
                }
#endif
            }
            public void Concatenate(Value x)
            {
                Unique();
                if (data.ArrayValue.Count == 0)
                {
                    data.Type = x.data.Type;
                }
                data.ArrayValue.AddRange(x.data.ArrayValue);
#if _TRACE_VALUE
                if (IsTarget())
                {
                    Console.WriteLine("V:Concatenate " + AsString());
                }
#endif
            }
            public double AsReal()
            {
                if (data == null)
                {
                    return 0;
                }
                switch (data.Type.Kind)
                {
                    case TypeKind.TK_REAL: return data.RealValue;
                    case TypeKind.TK_CHAR: return data.CharValue;
                    case TypeKind.TK_BOOLEAN: return data.BooleanValue ? 1 : 0;
                    case TypeKind.TK_ARRAY:
                        double number;
                        if (data.Type.Element.Kind == TypeKind.TK_CHAR && double.TryParse(AsString(), out number))
                        {
                            return number;
                        }
                        return 0;
                    default:
                        Debug.Assert(false);
                        return 0;
                }
            }
            public char AsChar()
            {
                if (data == null)
                {
                    return '\0';
                }
                switch (data.Type.Kind)
                {
                    case TypeKind.TK_REAL: return (char) data.RealValue;
                    case TypeKind.TK_CHAR: return data.CharValue;
                    case TypeKind.TK_BOOLEAN: return data.BooleanValue ? '1' : '0';
                    case TypeKind.TK_ARRAY: return '\0';
                    default:
                        Debug.Assert(false);
                        return '\0';
                }
            }
            public bool AsBoolean()
            {
                if (data == null)
                {
                    return false;
                }
                switch (data.Type.Kind)
                {
                    case TypeKind.TK_REAL: return data.RealValue != 0;
                    case TypeKind.TK_CHAR: return data.CharValue != '\0';
                    case TypeKind.TK_BOOLEAN: return data.BooleanValue;
                    case TypeKind.TK_ARRAY: return data.ArrayValue.Count != 0;
                    default:
                        Debug.Assert(false);
                        return false;
                }
            }
            public string AsString()
            {
                if (data == null)
                {
                    return "(VOID)";
                }
                switch (data.Type.Kind)
                {
                    case TypeKind.TK_REAL: return data.RealValue.ToString();
                    case TypeKind.TK_CHAR: return data.CharValue.ToString();
                    case TypeKind.TK_BOOLEAN: return data.BooleanValue ? "true" : "false";
                    case TypeKind.TK_ARRAY:
                        StringBuilder sb = new StringBuilder();
                        if (data.Type.Element.Kind == TypeKind.TK_CHAR)
                        {
                            foreach (Value v in data.ArrayValue)
                            {
                                sb.Append(v.AsChar());
                            }
                        }
                        else
                        {
                            sb.Append('[');
                            bool afterFirstValue = false;
                            foreach (Value v in data.ArrayValue)
                            {
                                if (afterFirstValue)
                                {
                                    sb.Append(',');
                                }
                                sb.Append(v.AsString());
                                afterFirstValue = true;
                            }
                            sb.Append(']');
                        }
                        return sb.ToString();
                    default:
                        Debug.Assert(false);
                        return "(INTERNAL-ERROR)";
                }
            }
            public int LengthAsArray()
            {
                Debug.Assert(data != null && data.Type.Kind == TypeKind.TK_ARRAY);
                return data.ArrayValue.Count;
            }
            public Value IndexAsArray(int i)
            {
                Debug.Assert(data != null && data.Type.Kind == TypeKind.TK_ARRAY);
                Debug.Assert(i < data.ArrayValue.Count);
                return data.ArrayValue[i];
            }
            public TypeData GetDataType()
            {
                Debug.Assert(data != null);
                return data.Type;
            }
            public void Unique()
            {
                if (data == null)
                {
                    data = new Body();
                    data.RefCount = 1;
                    data.Type = null;
                }
                else if (data.RefCount > 1)
                {
                    --(data.RefCount);
                    data = new Body(data);
                    data.RefCount = 1;
                }
#if _TRACE_VALUE
                if (IsTarget())
                {
                    Console.WriteLine("V:Unique " + AsString());
                }
#endif
            }
            public void Overwrite(Value source)
            {
                Debug.Assert(data != null);
                if (data == source.data)
                {
                    return;
                }
                Release();
                data = source.data; // TODO check logic
                data.RefCount = 2;
#if _TRACE_VALUE
                if (IsTarget())
                {
                    Console.WriteLine("V:Overwrite " + AsString());
                }
#endif
            }
            private void Release() // TODO remove
            {
                if (data != null)
                {
                    --(data.RefCount);
                    if (data.RefCount == 0)
                    {
                        data = null;
                    }
                }
            }
        }
    }
}
