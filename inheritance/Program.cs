using System;

namespace TryAbstract{
    abstract class Article{
        public string name{get;set;}
        public string publisher{get;set;}
        public int yearOfRelease{get;set;}

        public Article(string name,string publisher,int yearOfRelease){
            this.name = name;
            this.publisher = publisher;
            this.yearOfRelease = yearOfRelease;
        }
       
        public abstract void addArticle();
        public abstract void removeArticle();

    }

    class LP : Article{
        public string nameOfArticle{get;set;}
        public int noOfRecords{get;set;}

        public List<LP>  arr= new List<LP>();
        public LP (string nameOfArticle,int noOfRecords,string name,string publisher,int yearOfRelease) :base(name,publisher,yearOfRelease){
            this.nameOfArticle = nameOfArticle;
            this.noOfRecords = noOfRecords;
        }
         public override void addArticle(){
             
         }
        public override void removeArticle(){}
    }

    class Book : Article{
        public int noOfPlayers{get;set;}
        public int averagePlayertime{get;set;}
        public Book (int noOfPlayers,int averagePlayertime,string name,string publisher,int yearOfRelease) :base(name,publisher,yearOfRelease){
            this.noOfPlayers = noOfPlayers;
            this.averagePlayertime = averagePlayertime;
        }
         public override void addArticle(){

         }
        public override void removeArticle(){}
    }

    class BoardGame : Article{
        public string writer{get;set;}
        public string genere{get;set;}
        public BoardGame (string writer,string genere,string name,string publisher,int yearOfRelease) :base(name,publisher,yearOfRelease){
           this.writer = writer;
           this.genere = genere;
        }
         public override void addArticle(){}
        public override void removeArticle(){}
    }

    class MainProgram{
        public static void Main(string [] args){

            
        }
    }


}
