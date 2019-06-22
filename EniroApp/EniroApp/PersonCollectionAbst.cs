using System;

namespace EniroApp
{
    public abstract class AbstractClass
    {


        public void TemplateMethod()
        {
            Create();
            Delete();
            GetNumberOfEntries();
            UpdateUser();
        }

      

        public abstract void Create();

        public abstract void Delete();

        public abstract void GetNumberOfEntries();

        public abstract  void UpdateUser();

        




    }
    }
    
    
