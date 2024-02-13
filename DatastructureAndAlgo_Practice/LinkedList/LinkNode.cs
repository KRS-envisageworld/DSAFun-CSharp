using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.LinkedList
{
	public class LinkNode
	{
		public int Value { get; set; }
		public LinkNode Next { get; set; }

		public void start()
		{

			LinkedList<string> list = new LinkedList<string>();
			list.RemoveLast();
			// meory loc t1:123 t2: 3563
		}
	}

	public class Test
	{
		public string property { get; set; }
		public Test NestedObj { get; set; }
		public Test(string data)
		{
			property = data;
		}
	}
}
