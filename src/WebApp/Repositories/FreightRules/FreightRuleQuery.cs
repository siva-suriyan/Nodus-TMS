﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity.SqlServer;
using Repository.Pattern.Repositories;
using Repository.Pattern.Ef6;
using System.Web.WebPages;
using WebApp.Models;

namespace WebApp.Repositories
{
/// <summary>
/// File: FreightRuleQuery.cs
/// Purpose: easyui datagrid filter query 
/// Created Date: 2019/8/7 18:40:00
/// Author: neo.zhu
/// Tools: SmartCode MVC5 Scaffolder for Visual Studio 2017
/// Copyright (c) 2012-2018 All Rights Reserved
/// </summary>
   public class FreightRuleQuery:QueryObject<FreightRule>
   {
		public FreightRuleQuery Withfilter(IEnumerable<filterRule> filters)
        {
           if (filters != null)
           {
               foreach (var rule in filters)
               {
						if (rule.field == "Id" && !string.IsNullOrEmpty(rule.value) && rule.value.IsInt())
						{
							var val = Convert.ToInt32(rule.value);
							switch (rule.op) {
                            case "equal":
                                And(x => x.Id == val);
                                break;
                            case "notequal":
                                And(x => x.Id != val);
                                break;
                            case "less":
                                And(x => x.Id < val);
                                break;
                            case "lessorequal":
                                And(x => x.Id <= val);
                                break;
                            case "greater":
                                And(x => x.Id > val);
                                break;
                            case "greaterorequal" :
                                And(x => x.Id >= val);
                                break;
                            default:
                                And(x => x.Id == val);
                                break;
                        }
						}
						if (rule.field == "ORIGINAL"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.ORIGINAL.Contains(rule.value));
						}
						if (rule.field == "DESTINATION"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.DESTINATION.Contains(rule.value));
						}
						if (rule.field == "SHPTYPE"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.SHPTYPE.Contains(rule.value));
						}
						if (rule.field == "CALTYPE"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.CALTYPE.Contains(rule.value));
						}
						if (rule.field == "CARLWT1" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							switch (rule.op) {
                            case "equal":
                                And(x => x.CARLWT1 == val);
                                break;
                            case "notequal":
                                And(x => x.CARLWT1 != val);
                                break;
                            case "less":
                                And(x => x.CARLWT1 < val);
                                break;
                            case "lessorequal":
                                And(x => x.CARLWT1 <= val);
                                break;
                            case "greater":
                                And(x => x.CARLWT1 > val);
                                break;
                            case "greaterorequal" :
                                And(x => x.CARLWT1 >= val);
                                break;
                            default:
                                And(x => x.CARLWT1 == val);
                                break;
                        }
						}
						if (rule.field == "CARLWT2" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							switch (rule.op) {
                            case "equal":
                                And(x => x.CARLWT2 == val);
                                break;
                            case "notequal":
                                And(x => x.CARLWT2 != val);
                                break;
                            case "less":
                                And(x => x.CARLWT2 < val);
                                break;
                            case "lessorequal":
                                And(x => x.CARLWT2 <= val);
                                break;
                            case "greater":
                                And(x => x.CARLWT2 > val);
                                break;
                            case "greaterorequal" :
                                And(x => x.CARLWT2 >= val);
                                break;
                            default:
                                And(x => x.CARLWT2 == val);
                                break;
                        }
						}
						if (rule.field == "PRICE" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							switch (rule.op) {
                            case "equal":
                                And(x => x.PRICE == val);
                                break;
                            case "notequal":
                                And(x => x.PRICE != val);
                                break;
                            case "less":
                                And(x => x.PRICE < val);
                                break;
                            case "lessorequal":
                                And(x => x.PRICE <= val);
                                break;
                            case "greater":
                                And(x => x.PRICE > val);
                                break;
                            case "greaterorequal" :
                                And(x => x.PRICE >= val);
                                break;
                            default:
                                And(x => x.PRICE == val);
                                break;
                        }
						}
						if (rule.field == "MINAMOUNT" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							switch (rule.op) {
                            case "equal":
                                And(x => x.MINAMOUNT == val);
                                break;
                            case "notequal":
                                And(x => x.MINAMOUNT != val);
                                break;
                            case "less":
                                And(x => x.MINAMOUNT < val);
                                break;
                            case "lessorequal":
                                And(x => x.MINAMOUNT <= val);
                                break;
                            case "greater":
                                And(x => x.MINAMOUNT > val);
                                break;
                            case "greaterorequal" :
                                And(x => x.MINAMOUNT >= val);
                                break;
                            default:
                                And(x => x.MINAMOUNT == val);
                                break;
                        }
						}
						if (rule.field == "STATUS" && !string.IsNullOrEmpty(rule.value) && rule.value.IsInt())
						{
							var val = Convert.ToInt32(rule.value);
							switch (rule.op) {
                            case "equal":
                                And(x => x.STATUS == val);
                                break;
                            case "notequal":
                                And(x => x.STATUS != val);
                                break;
                            case "less":
                                And(x => x.STATUS < val);
                                break;
                            case "lessorequal":
                                And(x => x.STATUS <= val);
                                break;
                            case "greater":
                                And(x => x.STATUS > val);
                                break;
                            case "greaterorequal" :
                                And(x => x.STATUS >= val);
                                break;
                            default:
                                And(x => x.STATUS == val);
                                break;
                        }
						}
						if (rule.field == "DESCRIPTION"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.DESCRIPTION.Contains(rule.value));
						}
						if (rule.field == "LOTTABLE1"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.LOTTABLE1.Contains(rule.value));
						}
						if (rule.field == "LOTTABLE2"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.LOTTABLE2.Contains(rule.value));
						}
						if (rule.field == "LOTTABLE3" && !string.IsNullOrEmpty(rule.value) && rule.value.IsDecimal())
						{
							var val = Convert.ToDecimal(rule.value);
							switch (rule.op) {
                            case "equal":
                                And(x => x.LOTTABLE3 == val);
                                break;
                            case "notequal":
                                And(x => x.LOTTABLE3 != val);
                                break;
                            case "less":
                                And(x => x.LOTTABLE3 < val);
                                break;
                            case "lessorequal":
                                And(x => x.LOTTABLE3 <= val);
                                break;
                            case "greater":
                                And(x => x.LOTTABLE3 > val);
                                break;
                            case "greaterorequal" :
                                And(x => x.LOTTABLE3 >= val);
                                break;
                            default:
                                And(x => x.LOTTABLE3 == val);
                                break;
                        }
						}
						if (rule.field == "CreatedDate" && !string.IsNullOrEmpty(rule.value) )
						{	
							if (rule.op == "between")
                            {
                                var datearray = rule.value.Split(new char[] { '-' });
                                var start = Convert.ToDateTime(datearray[0]);
                                var end = Convert.ToDateTime(datearray[1]);
 
							    And(x => SqlFunctions.DateDiff("d", start, x.CreatedDate) >= 0);
                                And(x => SqlFunctions.DateDiff("d", end, x.CreatedDate) <= 0);
						    }
						}
						if (rule.field == "CreatedBy"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.CreatedBy.Contains(rule.value));
						}
						if (rule.field == "LastModifiedDate" && !string.IsNullOrEmpty(rule.value) )
						{	
							if (rule.op == "between")
                            {
                                var datearray = rule.value.Split(new char[] { '-' });
                                var start = Convert.ToDateTime(datearray[0]);
                                var end = Convert.ToDateTime(datearray[1]);
 
							    And(x => SqlFunctions.DateDiff("d", start, x.LastModifiedDate) >= 0);
                                And(x => SqlFunctions.DateDiff("d", end, x.LastModifiedDate) <= 0);
						    }
						}
						if (rule.field == "LastModifiedBy"  && !string.IsNullOrEmpty(rule.value))
						{
							And(x => x.LastModifiedBy.Contains(rule.value));
						}
     
               }
           }
            return this;
        }
    }
}
