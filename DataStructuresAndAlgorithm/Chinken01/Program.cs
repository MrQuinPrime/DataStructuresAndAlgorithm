using System;

namespace Chinken01
{
    class Program
    {
        static void Main(string[] args)
        {
            int chanticleer;//公鸡
            int biddy;//母鸡
            int chick;//小鸡
            int count = 0;

            for (chanticleer = 0; chanticleer <= 100; chanticleer++)
            {
                for (biddy = 0; biddy <= 100; biddy++)
                {
                    for (chick = 0; chick <= 100; chick = chick + 3)
                    {
                        if (5 * chanticleer + 3 * biddy + chick / 3 == 100 && chanticleer + biddy + chick == 100)
                        {
                            Console.WriteLine("公鸡有{0}只，母鸡有{1}只,小鸡有{2}只", chanticleer, biddy, chick);
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("一共有" + count + "种方法");
            Console.ReadLine();
        }
    }
}
