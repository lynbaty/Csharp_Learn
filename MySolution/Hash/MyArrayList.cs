using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class MyArrayList: ICollection
    {
        private object[] listObj;
      
        private const int MAXCOUNT = 100;

        public MyArrayList()
        {
            Count = -1;
            listObj = new object[MAXCOUNT];
        }
        public MyArrayList(int count)
        {
            this.Count = count;
            listObj = new object[count];

        }
        public MyArrayList(Array a)
        {
            a.CopyTo(listObj, 0);
            Count = a.Length;
        }
        public void CopyTo(Array array, int index)
        {
            listObj.CopyTo(array, index);

        }
        public int Count { get; set; }
        public bool InSynchronized { get { throw new NotImplementedException(); } }
        public object SyncRoot { get { throw new NotImplementedException(); } }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }



    }
}
