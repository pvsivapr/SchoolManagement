using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentExams : ContentPage
    {
        ObservableCollection<Exams> obcExamsData;
        public StudentExams()
        {
            InitializeComponent();
            obcExamsData = new ObservableCollection<Exams>()
            {
                new Exams{ExamNames="Unit 1", ExamDates="31/07/2017", ExamStatus="Completed", ExamResults="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Exams{ExamNames="Unit 2", ExamDates="11/09/2017", ExamStatus="Sheduled", ExamResults="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Exams{ExamNames="Quarterly", ExamDates="30/10/2017", ExamStatus="Sheduled", ExamResults="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Exams{ExamNames="Unit 3", ExamDates="10/12/2017", ExamStatus="Sheduled", ExamResults="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Exams{ExamNames="Half-Yearly", ExamDates="11/01/2017", ExamStatus="Sheduled", ExamResults="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Exams{ExamNames="Unit 4", ExamDates="24/02/2017", ExamStatus="Sheduled", ExamResults="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Exams{ExamNames="Annual", ExamDates="11/04/2017", ExamStatus="Sheduled", ExamResults="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "}
            };
            lvExamsListDisplay.ItemsSource = obcExamsData;
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lvExamsListDisplay.ItemSelected += SelectedExamData;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        void SelectedExamData(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var examData = ((ListView)sender).SelectedItem as Exams;
                if (examData == null)
                {
                    return;
                }
                Navigation.PushModalAsync(new StudentExamsDetail(examData));
                ((ListView)sender).SelectedItem = null;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
    public class Exams
    {
        public string ExamNames { get; set; }

        public string ExamDates { get; set; }

        public string ExamStatus { get; set; }

        public string ExamResults { get; set; }
    }
}
