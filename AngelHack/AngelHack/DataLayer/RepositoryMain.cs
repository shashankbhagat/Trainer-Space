using AngelHack.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelHack.DataLayer
{
    public class RepositoryMain
    {
        public static List<SelectListItem> getLocations()
        {
            List<SelectListItem> locList = new List<SelectListItem>();
            try
            {
                string sql = "Select Id,Name from Location";
                DataTable dt = DataAccess.GetManyRowsCols(sql, null);
                foreach(DataRow dr in dt.Rows)
                {
                    SelectListItem si = new SelectListItem();
                    si.Text = dr["Name"].ToString();
                    si.Value = dr["Name"].ToString();
                    locList.Add(si);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return locList;
        }

        public static List<SelectListItem> getStudioType()
        {
            List<SelectListItem> studioList = new List<SelectListItem>();
            try
            {
                string sql = "Select Id, Title from SpaceType";
                DataTable dt = DataAccess.GetManyRowsCols(sql, null);
                foreach (DataRow dr in dt.Rows)
                {
                    SelectListItem si = new SelectListItem();
                    si.Text = dr["Title"].ToString();
                    si.Value = dr["Title"].ToString();
                    studioList.Add(si);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return studioList;
        }

        public static List<MainVM> getSpacewithAvailibility(string location, string studioType)
        {
            List<MainVM> mainList = new List<MainVM>();
            try
            {
                string sql = "select s.Id as Id,s.Title as Title,s.ImageUrl as ImageUrl,case when isnull(b.Id,0)=0 then 0 else 1 end as Available from Space s inner join Location l on (s.LocationId=l.Id) inner join SpaceType sp on(sp.Id = s.SpaceTypeId) left join Booking b on(s.Id = b.SpaceId and convert(date,b.timeIn)=convert(date,getdate()) ) where l.Name = @location and sp.Title = @studioType";
                List<SqlParameter> pList = new List<SqlParameter>();
                SqlParameter p1 = new SqlParameter("@location", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@studioType", SqlDbType.VarChar);
                
                p1.Value = location;
                p2.Value = studioType;
                

                pList.Add(p1);
                pList.Add(p2);
                
                DataTable dt = DataAccess.GetManyRowsCols(sql, pList);
                foreach(DataRow dr in dt.Rows)
                {
                    MainVM mvm = new MainVM();
                    mvm.Id = (int)dr["Id"];
                    mvm.ImageUrl = dr["ImageUrl"].ToString();
                    mvm.Title = dr["Title"].ToString();
                    mvm.Available = (int)dr["Available"];
                    mainList.Add(mvm);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return mainList;
        }
    }
}