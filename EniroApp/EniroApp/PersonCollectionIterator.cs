using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EniroApp
{
    class PersonCollectionIterator :ICustomIterator
    {
        private Hashtable contactList;

        int position;
        String [] keyArray;
    

        public PersonCollectionIterator(Hashtable ht)
        {
            keyArray = (string[])ht.Keys;
            position = 0;
            contactList = ht;
        }



        public object Current => contactList[position];

        public object MoveNext()
        {
            position += 1;

            if (!(IsDone() == true))
            {
                return contactList[position];
            }
            else
            {
                return null;
            }
        }

        public bool IsDone()
        {
            if (!(position > keyArray.Count()))
            {
                return false;
            }
            return true;
        }
    }

}

