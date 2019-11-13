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
            protected readonly Vehicle[] vehicles;

        public Garage(int maxcapacity)
        {

            this.maxcapacity = Math.Max(0, maxcapacity);
            vehicles = new Vehicle[this.maxcapacity];
        }



            //public int Count => vehicles.Count;
            //public bool IsFull => maxcapacity <= Count;



            public void Add(T item)
            {
                Console.WriteLine("in lopp");
                for (int i = 0; i < maxcapacity; i++)
                {
                    if(vehicles[i]==null)
                    { 
                        vehicles[i] = item;
                        Console.WriteLine(item.Toprint());
                    }
                }
            
            //vehicles[indexnum] = item;
            //return( indexnum + 1);


            }

            //public void Remove(T item) => vehicles.Remove(item);
            public IEnumerator<T> GetEnumerator()
            {
                //return list.GetEnumerator();
                foreach (T item in vehicles)
                {
                  yield return item;
                }
            }

            

            //public void WriteAll(Action<T> action)
            //{

            //    vehicles.ForEach(i => action.Invoke(i));
            //    //foreach (var item in list)
            //    //{
            //    //    action.Invoke(item);
            //    //}

            //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        
    }

    }
