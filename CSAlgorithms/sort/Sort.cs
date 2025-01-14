﻿using System;

namespace CSAlgorithms.sort
{
    public class Sort<T>
    {
        private T[] Data { get; }
        
        private bool Ascend { get; }

        public Sort(T[] Data, bool Ascend)
        {
            this.Data = Data;
            this.Ascend = Ascend;
        }

        public T[] Solve()
        {
            T[] output = (T[]) Data.Clone();
            Type type = output.GetType();

            if (type.Equals(typeof(int[])))
            {
                int temp;
                for (int i = 0; i < output.Length; i++)
                {
                    for (int k = i + 1; k < output.Length; k++)
                    {
                        if (Convert.ToInt32(output[i]) > Convert.ToInt32(output[k]) && Ascend)
                        {
                            temp = Convert.ToInt32(output[i]);
                            output[i] = output[k];
                            output[k] = (T) (object) temp;
                        }
                        else if (Convert.ToInt32(output[i]) < Convert.ToInt32(output[k]) && !Ascend)
                        {
                            temp = Convert.ToInt32(output[i]);
                            output[i] = output[k];
                            output[k] = (T) (object) temp;
                        }
                    }
                }
            }
            else if (type.Equals(typeof(string[])))
            {
                string temp;
                for (int i = 0; i < output.Length; i++)
                {
                    for (int k = i + 1; k < output.Length; k++)
                    {
                        if (Convert.ToString(output[i]).CompareTo(Convert.ToString(output[k])) > 0 && Ascend)
                        {
                            temp = Convert.ToString(output[i]);
                            output[i] = output[k];
                            output[k] = (T) (object) temp;
                        }
                        else if (Convert.ToString(output[i]).CompareTo(Convert.ToString(output[k])) < 0 && !Ascend)
                        {
                            temp = Convert.ToString(output[i]);
                            output[i] = output[k];
                            output[k] = (T) (object) temp;
                        }
                    }
                }
            }

            return output;
        }
    }
}
