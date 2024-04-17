using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace var_4
{
    class Array
    {
        private int[] array;
        Random rnd = new Random();
        public int[] Size(int size)
        {
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(-100,100);
            }
            return array;
        }

        public string Number(int index)
        {
            if (index >= array.Length || index < 0) return $"нет элемента с такой позицией";
            else return $"результат: {array[index]}";
        }
        public int Element (int[] mas, int index)
        {
            return mas[index];
        }
        public int[] Out(int[] mas, int index)
        {
            int count = 0;
            for (int i = index; i < mas.Count(); i++)
            {
                count++;
            }
            int[] mas2 = new int[count];
            int j = 0;
            for (int i = index; i < mas.Count(); i++)
            {
                mas2[j] = mas[i];
                j++;
            }
            return mas2;
        }
        public int[] Multiply(int[] mas, int mult)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] *= mult;
            }
            return mas;
        }
        public ArrayList Operation (int[] mas1, int[] mas2, string answer)
        {
            ArrayList arrayList = new ArrayList();
                if(answer=="+")
                    for (int i = 0; i < mas1.Count(); i++)
                    {
                        arrayList.Add(mas1[i] + mas2[i]);
                    }
                else
                    for (int i = 0; i < mas1.Count(); i++)
                    {
                        arrayList.Add(mas1[i] - mas2[i]);
                    }
            return arrayList;
        }
    }
}

