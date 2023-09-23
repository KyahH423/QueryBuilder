/*       
 *--------------------------------------------------------------------
 * 	   File name: BannedGame.cs
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
    public class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Series { get; set; }
        public string Country { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;

        public BannedGame() 
        { 
            Id = 0;
            Title = string.Empty;
            Series = string.Empty;
            Country = string.Empty;
            Details = string.Empty;
        }
        
        public BannedGame(int id, string title, string series, string country, string details)
        {
            Id = id;
            Title = title;
            Series = series;
            Country = country;
            Details = details;
        }

        public override string ToString()
        {
            string msg = $"Id: {Id}";
            msg += $"Title: {Title}";
            msg += $"Series: {Series}";
            msg += $"Country: {Country}";
            msg += $"Details: {Details}";
            return msg;
        }

    }
}
