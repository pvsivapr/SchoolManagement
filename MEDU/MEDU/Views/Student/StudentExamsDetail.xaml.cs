using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentExamsDetail : ContentPage
    {
        public StudentExamsDetail(Exams selectedExamData)
        {
            InitializeComponent();
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lblNameData.Text = selectedExamData.ExamNames;
            lblDateData.Text = selectedExamData.ExamDates;
            lblResultData.Text = selectedExamData.ExamResults;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
