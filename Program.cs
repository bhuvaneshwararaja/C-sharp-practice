using System;
namespace Palindrome{
    class Count{
        static void Main(string[] args){
            int[] arr = new int[4];
            int count=0;
            for(int i=0;i<arr.Length;i++){
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int i in arr){
                int num = i;
                int sum=0,rem=0;
                while(num > 0){
                    rem = num%10;
                    sum=sum*10+rem;
                    num = num/10;
                }
                if (i == sum){
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}