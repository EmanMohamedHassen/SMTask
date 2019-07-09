using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Service.IRepository;

namespace SM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private IFaculty _FacultyRepo { get; }
        public FacultyController(IFaculty StudentRepo)
        {
            this._FacultyRepo = StudentRepo;
        }
        [HttpGet("GetFaculties")]
        [ProducesResponseType(typeof(List<Faculty>), 200)]
        public IActionResult GetFaculties()
        {
            try
            {
                var faculties = _FacultyRepo.GetFaculties();
                return Ok(new { RequestSuccess = true, ErrorMsg = "", content = faculties });
            }
            catch (Exception ex)
            {
                return Ok(new { RequestSuccess = false, ErrorMsg = ex.Message, content = "" });
            }
        }
    }
}