using System;

namespace shopping{
    class Product{
        public int product_id{get;set;}
        public string name{get;set;}
        public string brand{get;set;}
        public double price{get;set;}

        public Product(int product_id,string name,string brand,double price){
            this .product_id = product_id;
            this.name = name;
            this.brand = brand;
            this.price = price;
        }
    }

    class ShoppingMart{
        public List<Product> cart = new List<Product>();

        public int SameBrandName(string brand){
                int count = 0;
                foreach(var product in cart){
                    if(product.brand.ToLower() == brand.ToLower()){
                        count++;
                    }
                }
                if(count == 0) return 0;
                else return count;
        }
        public double SumOfPriceOfAllProducts(){
            double total = 0;
            foreach(var product in cart){
                total+=product.price;
            }

            return total;
        }
    }
    
    class MainProgram{
            public static void Main(string[] args){

                ShoppingMart manager = new ShoppingMart();
                Console.WriteLine("Enter the number of product to add in cart");
                int n = int.Parse(Console.ReadLine());
                for(int i=0;i<n;i++){
                    Console.WriteLine("Enter the productID");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the product name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the product brand");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Enter the product price");
                    double price= double.Parse(Console.ReadLine());

                    manager.cart.Add(new Product(id,name,brand,price));
                }

                Console.WriteLine("Enter your choice 1.Count brand name 2.Total price in cart");
                int ch = int.Parse(Console.ReadLine());
                switch(ch){
                    case 1:{
                        Console.WriteLine("Enter the brand to count");
                        string temp = Console.ReadLine();
                        int c = manager.SameBrandName(temp);
                        if (c != 0 )Console.WriteLine($"Count of particular brand in cart is {c}");
                        else Console.WriteLine("NO product available");
                        break;
                    }
                    case 2:{
                        double tot = manager.SumOfPriceOfAllProducts();
                        if(tot == 0) Console.WriteLine("No product available");
                        else Console.WriteLine($"Total price from the cart is {tot}");
                        break;
                    }
                    default:{
                        Console.WriteLine("Invalid Selection");
                        break;
                    }
                }

            }
    }

}