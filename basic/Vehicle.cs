using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Drive
{
    public class Vehicle{

        string Name {get;set;}
        int Id{get;set;}

        public Vehicle(){
          
        }

        public override string ToString()
        {
            return this.Name="Verna";
           
        }
        
    }
}