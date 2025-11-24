using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {

        public static void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            // Створення об'єкту лікарні
            Hospital hospital = new();

            //Додавання лікарів
            hospital.AddDoctor(new Doctor(1, "Максим Присяжнюк", "Терапевт"));
            hospital.AddDoctor(new Doctor(2, "Віталій Макарчук", "Хірург"));
            hospital.AddDoctor(new Doctor(3, "Володимир Остапенко", "Ортопед"));

            //Реєстрація пацієнтів
            hospital.RegisterPatient(new Patient(1, "Андрій Ковальчук", 25));
            hospital.RegisterPatient(new Patient(2, "Марина Шевченко", 18));
            hospital.RegisterPatient(new Patient(3, "Олег Тимошенко", 22));
            hospital.RegisterPatient(new Patient(4, "Ірина Довженко", 20));

            // Створення палат
            hospital.CreateRoom(new HospitalRoom(102, 2));
            hospital.CreateRoom(new HospitalRoom(103, 1));
            hospital.CreateRoom(new HospitalRoom(104, 3));

            // Госпіталізація
            hospital.HospitalizePatient(1, 102);
            hospital.HospitalizePatient(2, 102);
            hospital.HospitalizePatient(3, 103);
            hospital.HospitalizePatient(4, 104);

            // Медичні записи
            hospital.AddMedicalRecord(new MedicalRecord(
                 hospital.Patients[0],
                 hospital.Doctors[0],
                 DateTime.Now,
                 "Проведено огляд. Призначено курс лікування від застуди."));

            hospital.AddMedicalRecord(new MedicalRecord(
                hospital.Patients[1],
                hospital.Doctors[1],
                DateTime.Now,
                "Хірургічне втручання виконано успішно."));

            hospital.AddMedicalRecord(new MedicalRecord(
                hospital.Patients[2],
                hospital.Doctors[2],
                DateTime.Now,
                "Виписати план лікування"));
            hospital.AddMedicalRecord(new MedicalRecord(
                hospital.Patients[3],
                hospital.Doctors[1],
                DateTime.Now,
                "Покласти на лікування в стаціонар"));

            // Історія пацієнта
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }
            // Статистика
            Console.WriteLine(hospital.GetStatistics());

        }
    }
}
