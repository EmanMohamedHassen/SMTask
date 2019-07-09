using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Service.IRepository;

namespace SM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudent _StudentRepo { get; }
        public StudentController(IStudent StudentRepo)
        {
            this._StudentRepo = StudentRepo;
        }

        [HttpGet("GetStudents")]
        [ProducesResponseType(typeof(List<Student>), 200)]
        public IActionResult GetStudents()
        {
            try
            {
                var students = _StudentRepo.GetStudents();
                return Ok(new { RequestSuccess = true, ErrorMsg = "", content = students });
            }
            catch (Exception ex)
            {
                return Ok(new { RequestSuccess = false, ErrorMsg = ex.Message, content = "" });
            }
        }

        [HttpGet("GetStudent")]
        [ProducesResponseType(typeof(Student), 200)]
        public IActionResult GetStudent(int StudentID)
        {
            try
            {
                Student student = _StudentRepo.GetStudent(StudentID);
                return Ok(new { RequestSuccess = true, ErrorMsg = "", content = student });
            }
            catch (Exception ex)
            {
                return Ok(new { RequestSuccess = false, ErrorMsg = ex.Message, content = "" });
            }
        }

        [HttpPost("InsertStudent")]
        [ProducesResponseType(typeof(Student), 200)]
        public IActionResult InsertStudent(Student studentData)
        {
            try
            {
                Student student = _StudentRepo.InsertStudent(studentData);
                return Ok(new { RequestSuccess = true, ErrorMsg = "", content = student });
            }
            catch (Exception ex)
            {
                return Ok(new { RequestSuccess = false, ErrorMsg = ex.Message, content = "" });
            }
        }

        [HttpPost("UpdateStudent")]
        [ProducesResponseType(typeof(Student), 200)]
        public IActionResult UpdateStudent(Student studentData)
        {
            try
            {
                Student student = _StudentRepo.UpdateStudent(studentData);
                return Ok(new { RequestSuccess = true, ErrorMsg = "", content = student });
            }
            catch (Exception ex)
            {
                return Ok(new { RequestSuccess = false, ErrorMsg = ex.Message, content = "" });
            }
        }

        [HttpPost("DeleteStudent")]
        [ProducesResponseType(typeof(Student), 200)]
        public IActionResult DeleteStudent(int StudentID)
        {
            try
            {
                bool res = _StudentRepo.Delete(StudentID);
                return Ok(new { RequestSuccess = true, ErrorMsg = "", content = res });
            }
            catch (Exception ex)
            {
                return Ok(new { RequestSuccess = false, ErrorMsg = ex.Message, content = "" });
            }
        }

    }
}