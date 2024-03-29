﻿using QTS_SimpleBilling.Model;
using QTS_SimpleBilling.BAL;
using System.Collections.Generic;
using System.Linq;
using System;
using QTS_SimpleBilling.Repo.CatagoryRepo;

namespace QTS_SimpleBilling.CatRepo
{
    
        public class CatagoryRepo : ICatagoryRepo
        {
            public int Create(Catagory t)
            {
                int result = 0;
                try
                {
                    using BillingContext context = new BillingContext();
                    var cus = context.catagories.FirstOrDefault(c => c.CatagoryId == t.CatagoryId);

                    if (cus == null)
                    {
                        context.Add(t);
                        return result = context.SaveChanges();
                    }
                    else
                    {
                        return Update(t);
                    }
                }
                catch (Exception ex)
                {
                    Exc.ErMessage(ex);
                    return result = 0;
                }
            }

            public int Delete(Catagory t)
            {
                int result = 0;
                try
                {
                    using BillingContext context = new BillingContext();
                    context.catagories.Remove(t);
                    return result = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Exc.ErMessage(ex);
                    return result;
                }
            }

            public List<Catagory> Search(string t)
            {
                try
                {
                    using BillingContext context = new BillingContext();
                    return context.catagories.Where(c =>
                                                      c.CatagoryName.Contains(t) ||
                                                   
                                                      c.CatagoryId.ToString() == t).ToList();
                }
                catch (Exception ex)
                {
                    Exc.ErMessage(ex);
                    return null;
                }
            }

            public int Update(Catagory t)
            {
                int result = 0;
                try
                {
                    using BillingContext context = new BillingContext();
                    context.Update(t);
                    return result = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Exc.ErMessage(ex);
                    return result;
                }
            }

            public List<Catagory> View()
            {
                try
                {
                    using BillingContext _context = new BillingContext();
                    return _context.catagories.ToList();
                }
                catch (Exception ex)
                {
                    Exc.ErMessage(ex);
                    return null;
                }
            }
        }
    }

