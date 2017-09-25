using System;

namespace ch0402_Bridge.BusinessObject
{
    class BusinessObject
    {
        private DataObject dataObject;
        protected string group;
        public BusinessObject(string group)
        {
            this.group = group;
        }

        public DataObject DataObject
        {
            get { return dataObject; }
            set { dataObject = value; }
        }

        public virtual void Next()
        {
            dataObject.NextRecord();
        }
        public virtual void Prior()
        {
            dataObject.PriorRecord();
        }
        public virtual void New(string name)
        {
            dataObject.NewRecord(name);
        }
        public virtual void Delete(string name)
        {
            dataObject.DeleteRecord(name);
        }
        public virtual void Show()
        {
            dataObject.ShowRecord();
        }
        public virtual void ShowAll()
        {
            Console.WriteLine("客户集合：{0}", group);
            dataObject.ShowAllRecords();
        }
    }
}
