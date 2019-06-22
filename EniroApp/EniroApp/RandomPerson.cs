 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EniroApp
{
  public  class RandomPerson:Person
    {

        private static RandomPerson randomPerson;

        private RandomPerson()
        {

        }

 public static RandomPerson GetInstance()
        {
            if (randomPerson == null)
            {
                randomPerson = new RandomPerson();
            }
            return randomPerson;
        }


    }
}
