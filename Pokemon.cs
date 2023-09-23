/*       
 *--------------------------------------------------------------------
 * 	   File name: Pokemon.cs
 * 	Project name: Query Builder
 *--------------------------------------------------------------------
 * Author’s name and email:	 Kyah Hanson - hansonkm@etsu.edu				
 *          Course-Section:  CSCI-2910-800
 *           Creation Date:	 9/18/2023		
 * -------------------------------------------------------------------
 */
using Microsoft.VisualBasic;
using QueryBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    public class Pokemon: IClassModel
    {
        public int Id { get; set; }
        public int DexNumber { get; set; }
        public string Name { get; set; } = string.Empty;        
        public string Form { get; set; } = string.Empty;
        public string Type1 { get; set; } = string.Empty;
        public string Type2 { get; set; } = string.Empty;
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set;}
        public int SpecialDefense { get; set;}
        public int Speed { get; set; }
        public int Generation { get; set; }

        public Pokemon() 
        {
            Id = 0;
            DexNumber = 0;
            Name = "No Name";
            Form = "No Form";
            Type1 = "No Type";
            Type2 = "No Type";
            Total = 0;
            HP = 0;
            Attack = 0;
            Defense = 0;
            SpecialAttack = 0;
            SpecialDefense = 0;
            Speed = 0;
            Generation = 0;
        }

        public Pokemon(int id, int dexNumber, string name, string form, string type1, string type2, int total, int hP, int attack, int defense, int specialAttack, int specialDefense, int speed, int generation)
        {
            Id = id;
            DexNumber = dexNumber;
            Name = name;
            Form = form;
            Type1 = type1;
            Type2 = type2;
            Total = total;
            HP = hP;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
            Generation = generation;
        }

        public override string ToString()
        {
            string msg = $"Id: {Id}";
            msg += $"DexNumber: {DexNumber}";
            msg += $"Name: {Name}";
            msg += $"Form: {Form}";
            msg += $"Type 1: {Type1}";
            msg += $"Type 2: {Type2}";
            msg += $"Total: {Total}";
            msg += $"HP: {HP}";
            msg += $"Attack: {Attack}";
            msg += $"Defense: {Defense}";
            msg += $"Special Attack: {SpecialAttack}";
            msg += $"Special Defense: {SpecialDefense}";
            msg += $"Speed: {Speed}";
            msg += $"Generation: {Generation}";
            return msg;
        }
    }
}
