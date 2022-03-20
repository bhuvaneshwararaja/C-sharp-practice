// using System;

// class PrimeArray{
//     static  void Main(string[] args){
//         int[] arr = new int[4];
//         int count=0;
//         for(int i=0;i<arr.Length;i++){
//             arr[i] = int.Parse(Console.ReadLine());
//         }
//         foreach(int i in arr){
//             int flag = 0;
//             for(int j=2;j<i/2;j++){
//                 if(i%j == 0){
//                     flag =1;
//                     break;
//                 }
//             }
//             if(flag == 0){
//                 count++;
//             }
//             else{
//                 flag=0;
//             }
//         }
//         Console.WriteLine(count);

//     }   
// }

using System;

class Alpha{
    static  void Main(string[] args){
        string s = Console.ReadLine();
        int sum = 0;
        for(int i=0;i<s.Length;i++){
            if(s[i] >= '0' && s[i] <= '9'){
                int temp = int.Parse(s[i].ToString());
                sum= sum+temp;

            }
        }
        Console.WriteLine(sum);
    }
}