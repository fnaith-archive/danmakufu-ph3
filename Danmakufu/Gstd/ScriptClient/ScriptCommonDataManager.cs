using System.Collections.Generic;
using Gstd.Script;

namespace Gstd.ScriptClient
{
    sealed class ScriptCommonDataManager
    {
        //protected gstd.CriticalSection lock_ = new gstd.CriticalSection(); TODO remove
        protected string nameAreaDefailt = "";
        protected SortedDictionary<string, ScriptCommonData> mapData = new SortedDictionary<string, ScriptCommonData>();
        public ScriptCommonDataManager()
        {
            nameAreaDefailt = "";
            CreateArea("");
        }
        public void Clear()
        {
            mapData.Clear();
        }
        public string GetDefaultAreaName()
        {
            return nameAreaDefailt;
        }
        public void SetDefaultAreaName(string name)
        {
            nameAreaDefailt = name;
        }
        public bool IsExists(string name)
        {
            return mapData.ContainsKey(name);
        }
        public void CreateArea(string name)
        {
            if (IsExists(name))
            {
                return;
            }
            mapData[name] = new ScriptCommonData();
        }
        public void CopyArea(string nameDest, string nameSrc)
        {
            ScriptCommonData dataSrc = mapData[nameSrc];
            ScriptCommonData dataDest = new ScriptCommonData();
            dataDest.Copy(dataSrc);
            mapData[nameDest] = dataDest;
        }
        public ScriptCommonData GetData(string name)
        {
            if (!IsExists(name))
            {
                return null;
            }
            return mapData[name];
        }
        public void SetData(string name, ScriptCommonData commonData)
        {
            mapData[name] = commonData;
        }
        public List<string> GetKeyList()
        {
            List<string> res = new List<string>();
            SortedDictionary<string, ScriptCommonData>.Enumerator itrValue;
            for (itrValue = mapData.GetEnumerator(); itrValue.MoveNext();)
            {
                string key = itrValue.Current.Key;
                res.Add(key);
            }
            return res;
        }
        /*public gstd.CriticalSection GetLock() TODO remove
        {
            return new gstd.CriticalSection(lock_);
        }*/
    }
}
