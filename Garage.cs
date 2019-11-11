using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Garage1._0
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {

            private readonly int maxcapacity;
            protected readonly List<Vehicle> vehicles;

            public Garage(int capacity)
            {

                this.maxcapacity = Math.Max(0, maxcapacity);
                vehicles = new List<Vehicle>(capacity);

            }



            public int Count => vehicles.Count;
            public bool IsFull => maxcapacity <= Count;



            public virtual bool Add(T item)
            {

                if (IsFull) return false;
                vehicles.Add(item);
                return true;

            }

            public bool Remove(T item) => vehicles.Remove(item);
            public IEnumerator<T> GetEnumerator()
            {
                //return list.GetEnumerator();
                foreach (T item in vehicles)
                {
                  yield return item;
                }
            }

            

            public void WriteAll(Action<T> action)
            {

                vehicles.ForEach(i => action.Invoke(i));
                //foreach (var item in list)
                //{
                //    action.Invoke(item);
                //}

            }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        
    }

    }
