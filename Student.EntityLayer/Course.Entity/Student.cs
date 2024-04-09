using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.EntityLayer.Course.Entity
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ModificationTime { get; set; }

        public bool IsDeleted { get; set; }

        public int IdCourse { get; set; }

        public Course Course { get; set; }

    }
}


/*Course
Id
Name
Duration (in months)
Price(AZN)
CreationTime
ModificationTime
Student
Id
Name
Surname
BirthDate
CreationTime
ModificationTime
Teacher
Id
Name
Surname
BirthDate
Profession*/






/*kurs
İd
ad
Müddət (aylarla)
Qiymət(AZN)
Yaradılma vaxtı
Modifikasiya vaxtı
tələbə
İd
ad
soyad
Doğum tarixi
Yaradılma vaxtı
Modifikasiya vaxtı
Müəllim
İd
ad
soyad
Doğum tarixi
Peşə
Tələblər
Kurs, Tələbə və Müəllim üçün CRUD funksiyasına malik olmalıyıq
Müəllim müxtəlif kursları öyrədə bilər, biz hansı kursların müəyyən 
bir müəllim tərəfindən tədris oluna biləcəyini saxlamalıyıq
Biz müəyyən müddət üçün kursa başlaya bilməliyik
(Planlaşdırılmış başlanğıc tarixi, Planlaşdırılan bitmə tarixi), tələbəni həmin 
    kursa qeydiyyatdan keçirməli və bu kurs üçün müvafiq müəllim təyin edə bilməliyik,
    (StudentId, TeacherId, CourseId, StartDate, EndDate)
Həftədə 2 dəfə kurs dərsləri keçirməyi planlaşdırmışdıq. Beləliklə, hər dərs üçün aşağıdakıları edə bilərik
- Tələbənin dərsdə iştirak edib-etmədiyini göstərin
- Tələbə və həmin dərs üçün bəzi qeydlər əlavə edin
Biz cari davam edən kursları izləməli, tələbələri və müəllimləri görməliyik,
tələbə seçməliyik və bütün irəliləyişləri görməliyik (hər dərs üçün)*/
