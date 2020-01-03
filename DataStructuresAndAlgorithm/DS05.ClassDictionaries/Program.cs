using System;
using System.Collections;

namespace DS05.ClassDictionaries
{
    class Program
    {
        static void Main()
        {
            IDictionary classMate = new ClassDictionary(4);

            // 添加字典元素，注意：key不能重复，value是可以重复的。
            classMate.Add("20180310077", "廖海东");
            classMate.Add("20180310076", "郝海东");
            classMate.Add("20180310075", "张海东");
            classMate.Add("20180310074", "李海东");

            foreach(DictionaryEntry v in classMate)
            {
                Console.WriteLine("学号{0}的姓名是{1}", v.Key, v.Value);
            }
            
            // 直接通过 key 名称来获取 value。 
            Console.WriteLine("键 = \"20180310077\", 值 = {0}.", classMate["20180310077"]);
            Console.WriteLine("--------------------------------------------------------------------------");

            // 修改 key 对应的 value
            classMate["20180310077"] = "廖凯撒";
            Console.WriteLine("键 = \"20180310077\", 值 = {0}.", classMate["20180310077"]);
            Console.WriteLine("--------------------------------------------------------------------------");

            // 移除一个字典元素
            Console.WriteLine("移除 (\"20180310076\")");
            classMate.Remove("20180310076");
            if (!classMate.Contains("20180310076"))
            {
                Console.WriteLine("键为 \"20180310076\" 不存在。");
            }
            Console.ReadLine();
        }
    }
}
