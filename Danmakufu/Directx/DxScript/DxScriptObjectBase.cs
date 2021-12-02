using System;
using System.Collections.Generic;
using Gstd.Script;
using Gstd.ScriptClient;
using Directx.DxScript;

namespace Directx.DxScript
{
    public abstract class DxScriptObjectBase : IDisposable
    {
        protected int idObject;
        protected int typeObject;
        protected long idScript;
        protected DxScriptObjectManager manager;
        protected double priRender;
        protected bool bVisible;
        protected bool bDeleted;
        protected bool bActive;
        protected Dictionary<string, Value> mapObjectValue = new Dictionary<string, Value>();
        public DxScriptObjectBase()
        {
            bVisible = true;
            priRender = 0.5;
            bDeleted = false;
            bActive = false;
            manager = null;
            idObject = DxScript.ID_INVALID;
            idScript = ScriptClientBase.ID_SCRIPT_FREE;
            typeObject = DxScript.OBJ_INVALID;
        }
        public virtual void Dispose()
        {
            if (manager != null && idObject != DxScript.ID_INVALID)
            {
                //manager.listUnusedIndex.Add(idObject); TODO
            }
        }
        public void SetObjectManager(DxScriptObjectManager manager)
        {
            this.manager = manager;
        }
        public virtual void Initialize()
        {
        }
        public virtual void Work()
        {
        }
        public abstract void Render();
        public abstract void SetRenderState();
        public int GetObjectID()
        {
            return idObject;
        }
        public int GetObjectType()
        {
            return typeObject;
        }
        public long GetScriptID()
        {
            return idScript;
        }
        public bool IsDeleted()
        {
            return bDeleted;
        }
        public bool IsActive()
        {
            return bActive;
        }
        public void SetActive(bool bActive)
        {
            this.bActive = bActive;
        }
        public bool IsVisible()
        {
            return bVisible;
        }
        public double GetRenderPriority()
        {
            return priRender;
        }
        /*public int GetRenderPriorityI() TODO remove
        {
            int res = (int)(priRender * (manager.GetRenderBucketCapacity() - 1) + 0.5);
            return res;
        }*/
        public void SetRenderPriority(double pri)
        {
            priRender = pri;
        }
        //void SetRenderPriorityI(int pri); TODO remove
        public bool IsObjectValueExists(string key)
        {
            return mapObjectValue.ContainsKey(key);
        }
        public Value GetObjectValue(string key)
        {
            return new Value(mapObjectValue[key]);
        }
        public void SetObjectValue(string key, Value val)
        {
            mapObjectValue[key].CopyFrom(val);
        }
        public void DeleteObjectValue(string key)
        {
            mapObjectValue.Remove(key);
        }
    }
}
