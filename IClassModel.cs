/*       
 *--------------------------------------------------------------------
 * 	   File name: IClassModel.cs
 * 	Project name: Query Builder
 *--------------------------------------------------------------------
 * Author’s name and email:	 Kyah Hanson - hansonkm@etsu.edu				
 *          Course-Section:  CSCI-2910-800
 *           Creation Date:	 9/18/2023		
 * -------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Models
{
    public interface IClassModel
    {
        public int Id { get; set; }
    }
}
