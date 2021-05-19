﻿using DO_AN_PBL3.Entity;
using DO_AN_PBL3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_PBL3.DAL
{
    class Customer_DAL : IGeneral<KHACHHANG>
    {
        private PBL3_QLTraSuaEntities db;
        private static Customer_DAL _Instance;
        public static Customer_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Customer_DAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public Customer_DAL()
        {
            db = new PBL3_QLTraSuaEntities();
        }

        public List<KHACHHANG> GetList()
        {
            throw new NotImplementedException();
        }

        public List<KHACHHANG> GetList(int key)
        {
            throw new NotImplementedException();
        }

        public KHACHHANG GetKHByID(int id)
        {
            KHACHHANG kh = db.KHACHHANGs.FirstOrDefault(p => p.ID_KH == id);

            return kh;
        }

        public void Add(KHACHHANG temp)
        {
            throw new NotImplementedException();
        }

        public void Delete(KHACHHANG temp)
        {
            throw new NotImplementedException();
        }

        public void Sync()
        {
            throw new NotImplementedException();
        }
    }
}