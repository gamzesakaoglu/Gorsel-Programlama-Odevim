using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace Odev1
{
    public partial class YapilacaklarPage : ContentPage
    {
        private ObservableCollection<TaskItem> _taskList;

        public YapilacaklarPage()
        {
            InitializeComponent();

            _taskList = new ObservableCollection<TaskItem>();

            TaskListView.ItemsSource = _taskList;
        }

        private void AddTask_Clicked(object sender, EventArgs e)
        {
            string task = TaskEntry.Text;
            if (!string.IsNullOrWhiteSpace(task))
            {
                TaskItem taskItem = new TaskItem
                {
                    Task = task,
                    Date = DateTime.Now
                };

                _taskList.Add(taskItem);

                TaskEntry.Text = string.Empty;
            }
        }
    }

    public class TaskItem
    {
        public string Task { get; set; }
        public DateTime Date { get; set; }
    }
}
