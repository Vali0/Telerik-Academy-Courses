using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01Frames
{
    class Program
    {
        static SortedSet<string> result = new SortedSet<string>();
        static void Main(string[] args)
        {
            int numberOfFrames = int.Parse(Console.ReadLine());
            var frames = new Frame[numberOfFrames];
            for (int i = 0; i < numberOfFrames; i++)
            {
                var frameParameters = Console.ReadLine().Split(' ');
                frames[i] = new Frame()
                {
                   Width = int.Parse(frameParameters[0]), 
                   Height = int.Parse(frameParameters[1])
                };
            }

            Perm(frames, 0);
            Console.WriteLine(result.Count);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void Perm(Frame[] arr, int k)
        {
            if (k >= arr.Length)
            {
                result.Add(string.Join(" | ", arr));
            }
            else
            {
                Perm(arr, k + 1);
                SwapFrame(ref arr[k]);
                Perm(arr, k + 1);
                SwapFrame(ref arr[k]);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    Perm(arr, k + 1);
                    SwapFrame(ref arr[k]);
                    Perm(arr, k + 1);
                    SwapFrame(ref arr[k]);
                    SwapFrame(ref arr[k]);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        static void SwapFrame(ref Frame frame)
        {
            int tempHeight = frame.Height;
            frame.Height = frame.Width;
            frame.Width = tempHeight;
        }

        static void Swap(ref Frame firstElement, ref Frame secondElement)
        {
            var tempArr = firstElement;
            firstElement = secondElement;
            secondElement = tempArr;
        }

        static void Print(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        struct Frame
        {
            public int Width { get; set; }

            public int Height { get; set; }
            
            public override string ToString()
            {
                return string.Format("({0}, {1})", this.Width, this.Height);
            }
        }
    }
}