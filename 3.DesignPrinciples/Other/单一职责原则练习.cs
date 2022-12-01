using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单一职责原则练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counselor counselor = new Counselor();
            Tutor tutor = new Tutor();
        }
    }

    public interface IClassCommitteeConstruction
    {
        void ClassCommitteeConstruction();
    }

    public interface IAttendanceStatistics
    {
        void AttendanceStatistics();
    }

    public interface IPsychologicalCounseling
    {
        void PsychologicalCounseling();
    }

    public interface ITotalExpenses
    {
        void TotalExpenses();
    }

    public interface IClassManager
    {
        void ClassManager();
    }

    public interface IProfessionalGuidance
    {
        void ProfessionalGuidance();
    }

    public interface ILearnGuidance
    {
        void LearnGuidance();
    }

    public interface IResearchGuidance
    {
        void ResearchGuidance();
    }

    public interface IEmploymentGuidance
    {
        void EmploymentGuidance();
    }

    public class ClassCommitteeConstruction : IClassCommitteeConstruction
    {
        void IClassCommitteeConstruction.ClassCommitteeConstruction()
        {
            Console.WriteLine("班委建设");
        }
    }

    public class AttendanceStatistics : IAttendanceStatistics
    {
        void IAttendanceStatistics.AttendanceStatistics()
        {
            Console.WriteLine("出勤统计");
        }
    }

    public class PsychologicalCounseling : IPsychologicalCounseling
    {
        void IPsychologicalCounseling.PsychologicalCounseling()
        {
            Console.WriteLine("心理辅导");
        }
    }

    public class TotalExpenses : ITotalExpenses
    {
        void ITotalExpenses.TotalExpenses()
        {
            Console.WriteLine("费用统计");
        }
    }

    public class ClassManager : IClassManager
    {
        void IClassManager.ClassManager()
        {
            Console.WriteLine("班级管理");
        }
    }

    public class ProfessionalGuidance : IProfessionalGuidance
    {
        void IProfessionalGuidance.ProfessionalGuidance()
        {
            Console.WriteLine("专业辅导");
        }
    }

    public class LearnGuidance : ILearnGuidance
    {
        void ILearnGuidance.LearnGuidance()
        {
            Console.WriteLine("学习辅导");
        }
    }

    public class ResearchGuidance : IResearchGuidance
    {
        void IResearchGuidance.ResearchGuidance()
        {
            Console.WriteLine("科研辅导");
        }
    }

    public class EmploymentGuidance : IEmploymentGuidance
    {
        void IEmploymentGuidance.EmploymentGuidance()
        {
            Console.WriteLine("就业辅导");
        }
    }

    public class Counselor
    {
        private IClassCommitteeConstruction _iclassCommitteeConstruction;
        private IAttendanceStatistics _iattendanceStatistics;
        private IPsychologicalCounseling _ipsychologicalCounseling;
        private ITotalExpenses _itotalExpenses;
        private IClassManager _iclassManager;

        public void ClassCommitteeConstruction()
        {
            _iclassCommitteeConstruction.ClassCommitteeConstruction();
        }

        public void AttendanceStatistics()
        {
            _iattendanceStatistics.AttendanceStatistics();
        }

        public void PsychologicalCounseling()
        {
            _ipsychologicalCounseling.PsychologicalCounseling();
        }

        public void TotalExpenses()
        {
            _itotalExpenses.TotalExpenses();
        }

        public void ClassManager()
        {
            _iclassManager.ClassManager();
        }
    }

    public class Tutor
    {
        private IProfessionalGuidance _iprofessionalGuidance;
        private ILearnGuidance _ilearnGuidance;
        private IResearchGuidance _iresearchGuidance;
        private IEmploymentGuidance _iemploymentGuidance;

        public void ProfessionalGuidance()
        {
            _iprofessionalGuidance.ProfessionalGuidance();
        }

        public void LearnGuidance()
        {
            _ilearnGuidance.LearnGuidance();
        }

        public void ResearchGuidance()
        {
            _iresearchGuidance.ResearchGuidance();
        }

        public void EmploymentGuidance()
        {
            _iemploymentGuidance.EmploymentGuidance();
        }
    }
}
