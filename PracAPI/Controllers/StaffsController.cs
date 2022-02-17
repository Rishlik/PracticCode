﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PracAPI.Entities;
using PracAPI.Models;

namespace PracAPI.Controllers
{
    public class StaffsController : ApiController
    {
        private SaleComponentsEntities db = new SaleComponentsEntities();

        // GET: api/Staffs
        [ResponseType(typeof(List<ResponceModel>))]
        public IHttpActionResult GetStaffs()
        {
            return Ok(db.Staffs.ToList().ConvertAll(p=> new ResponceModel(p)));
        }

        // GET: api/Staffs/5
        [ResponseType(typeof(Staff))]
        public IHttpActionResult GetStaff(int id)
        {
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                return NotFound();
            }

            return Ok(staff);
        }

        // PUT: api/Staffs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStaff(int id, Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != staff.Id)
            {
                return BadRequest();
            }

            db.Entry(staff).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Staffs
        [ResponseType(typeof(Staff))]
        public IHttpActionResult PostStaff(Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Staffs.Add(staff);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = staff.Id }, staff);
        }

        // DELETE: api/Staffs/5
        [ResponseType(typeof(Staff))]
        public IHttpActionResult DeleteStaff(int id)
        {
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                return NotFound();
            }

            db.Staffs.Remove(staff);
            db.SaveChanges();

            return Ok(staff);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StaffExists(int id)
        {
            return db.Staffs.Count(e => e.Id == id) > 0;
        }
    }
}