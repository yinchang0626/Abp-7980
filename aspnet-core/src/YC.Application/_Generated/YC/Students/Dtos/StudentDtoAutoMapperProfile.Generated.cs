﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System.Reflection;
using AutoMapper;
using Volo.Abp.AutoMapper;

namespace YC.Students.Dtos
{
    public partial class StudentAutoMapperProfile : Profile
    {
        public StudentAutoMapperProfile()
        {
            CreateMap<YC.Students.Student, StudentDto>()
            .ReverseMap();
        
            CreateMap<StudentCreateDto, YC.Students.Student>();
        
            CreateMap<StudentUpdateDto, YC.Students.Student>();
        
            CreateMap<YC.Students.Student, StudentWithDetailsDto>();
        
            CustomizeConfiguration();
        }
        partial void CustomizeConfiguration();
    }

}
