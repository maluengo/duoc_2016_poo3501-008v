using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Backend.AppConfigManager;
using Backend.Domain.Dto;
using Backend.Tools;

namespace Backend.Domain.Students
{
    public class StudentsReader
    {

        /// <summary>
        /// Lista todos los estudiantes por pantalla, aquellos disponibles en el App.Config. 
        /// </summary>
        /// <returns></returns>
        public List<StudentsDto> GetAllStudents()
        {
            var studentsCollection = default(List<StudentsDto>);
            var allKeys            = ConfigurationManager.AppSettings.AllKeys;
            var configHelper       = new AppConfigReader();
            var stringHelper       = new StringHelper();

            if (allKeys.Any())
            {
                studentsCollection = new List<StudentsDto>();

                for (var iterator = 0; iterator <allKeys.Length; iterator ++)
                {

                    if (allKeys[iterator].StartsWith("alumno"))
                    {
                        var auxCashByStudent = configHelper.GetValueFromKeyInAppConfig(allKeys[iterator]); 

                        studentsCollection.Add(new StudentsDto()
                        {
                            CashByStudent = auxCashByStudent,
                            Name = stringHelper.GetSplitStringByIndex(1, allKeys[iterator], "_")
                        }); 
                    } 
                    
                }
            }   

            return studentsCollection;

        }

        /// <summary>
        /// Obtiene la nómina de alumnos pre-seleccionados, pero la filta por aquellos alumnos cuyo Cash esté por debajo del parámetro 'baseline'
        /// </summary>
        /// <param name="baseline"></param>
        /// <returns></returns>
        public List<StudentsDto> GetAllStudentsByBaseLine(int baseline)
        {
            var allStudents = default(List<StudentsDto>);

            if (!baseline.Equals(default(int)))
            {
                var auxAllStudents = GetAllStudents();

                if (auxAllStudents.Any())
                {
                    allStudents= new List<StudentsDto>();

                    foreach (var item in auxAllStudents)
                    {
                        var auxCashStuden = int.Parse(item.CashByStudent);

                        if (auxCashStuden <= baseline)
                        {
                            allStudents.Add(item);
                        }
                    }
                    
                }
            }

            return allStudents;
        } 


    }
}
