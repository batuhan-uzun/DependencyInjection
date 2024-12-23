﻿using DependencyInjection.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomsController : ControllerBase
    {
        private readonly ClassRoom _classRoom;

        public ClassRoomsController(ClassRoom classRoom)
        {
            _classRoom = classRoom;
        }
        [HttpGet]
        public IActionResult GetTeacherInfo()
        {
            var teacherInfo = _classRoom.GetTeacherInfo();

            return Ok(teacherInfo);

        }
    }
}
