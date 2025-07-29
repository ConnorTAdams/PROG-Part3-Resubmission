using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POEPART3
{
    public partial class MainForm: Form
    {
        private List<Task> taskList = new List<Task>();
        private List<QuizQuestion> quizQuestions = new List<QuizQuestion>();
        private int currentQuestionIndex = 0;
        private int score = 0;
        private List<string> activityLog = new List<string>();


        public MainForm()
        {
            InitializeComponent();
            btnAddTask.Click += btnAddTask_Click;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            btnSend.Click += btnSend_Click;
            btnShowLog.Click += btnShowLog_Click;



        }

        private void txtTaskTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text.Trim();
            string description = txtTaskDescription.Text.Trim();
            DateTime? reminder = dtpReminder.Checked ? dtpReminder.Value : (DateTime?)null;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            Task newTask = new Task
            {
                Title = title,
                Description = description,
                ReminderDate = reminder,
                IsCompleted = false
            };

            taskList.Add(newTask);

            
            txtTaskTitle.Clear();
            txtTaskDescription.Clear();
            dtpReminder.Value = DateTime.Now;
            dtpReminder.Checked = false;
            taskList.Add(newTask);
            RefreshTaskList();
            activityLog.Add($"Task added: {title}");


        }

        private void RefreshTaskList()
        {
            lstTasks.Items.Clear();

            foreach (var task in taskList)
            {
                lstTasks.Items.Add(task); 
            }
        }
        


        private void MainForm_Load(object sender, EventArgs e)
        {
            quizQuestions = new List<QuizQuestion>
    {
        new QuizQuestion
        {
            Question = "What should you do if you receive a suspicious email?",
            Options = new List<string> { "Reply with your password", "Click the link", "Report it as phishing", "Ignore it" },
            CorrectIndex = 2,
            Explanation = "Always report phishing emails to prevent scams."
        },
        new QuizQuestion
        {
            Question = "Which password is the strongest?",
            Options = new List<string> { "123456", "password", "MyDog2023", "T!g3r$#2025" },
            CorrectIndex = 3,
            Explanation = "Strong passwords use symbols, numbers, and uppercase/lowercase letters."
        },
        new QuizQuestion
        {
            Question = "What is two-factor authentication (2FA)?",
            Options = new List<string> { "Using two passwords", "Logging in from two devices", "Verifying identity with an extra step", "Using a friend's account" },
            CorrectIndex = 2,
            Explanation = "2FA adds an extra layer of security, like a code sent to your phone."
        },
        new QuizQuestion
        {
            Question = "Which of these is a sign of a phishing website?",
            Options = new List<string> { "HTTPS in the URL", "Spelling mistakes and strange URLs", "A padlock icon", "Professional layout" },
            CorrectIndex = 1,
            Explanation = "Phishing sites often have spelling errors or unusual URLs."
        },
        new QuizQuestion
        {
            Question = "Why should you update your software regularly?",
            Options = new List<string> { "To get new colors", "To fix bugs and security flaws", "To make your device faster", "To reset your settings" },
            CorrectIndex = 1,
            Explanation = "Updates fix vulnerabilities that hackers could exploit."
        },
        new QuizQuestion
        {
            Question = "True or False: Public Wi-Fi is always safe to use.",
            Options = new List<string> { "True", "False", "", "" },
            CorrectIndex = 1,
            Explanation = "Public Wi-Fi can be unsafe and expose you to attackers."
        },
        new QuizQuestion
        {
            Question = "What is a common tactic used in social engineering?",
            Options = new List<string> { "Sending malware in links", "Gaining trust to steal information", "Hacking routers", "Using encryption" },
            CorrectIndex = 1,
            Explanation = "Social engineering relies on manipulation and deception."
        },
        new QuizQuestion
        {
            Question = "Which file extension is most likely to be dangerous?",
            Options = new List<string> { ".exe", ".txt", ".jpg", ".mp3" },
            CorrectIndex = 0,
            Explanation = "Executable (.exe) files can install malware on your device."
        },
        new QuizQuestion
        {
            Question = "What should you do before clicking on a link in an email?",
            Options = new List<string> { "Click quickly before it expires", "Hover over the link to preview it", "Trust the sender name", "Forward it to friends" },
            CorrectIndex = 1,
            Explanation = "Hovering over links shows the actual URL and helps spot phishing."
        },
        new QuizQuestion
        {
            Question = "Which is the best way to store passwords?",
            Options = new List<string> { "Write them on paper", "Use the same one everywhere", "Store them in a password manager", "Send them to yourself in email" },
            CorrectIndex = 2,
            Explanation = "Password managers store credentials securely and generate strong passwords."
        }
    };
            currentQuestionIndex = 0;
            score = 0;
            LoadQuestion();
      

            currentQuestionIndex = 0;
            score = 0;
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (quizQuestions == null || quizQuestions.Count == 0)
            {
                lblQuestion.Text = "No quiz questions available.";
                return;
            }

            if (currentQuestionIndex >= quizQuestions.Count)
            {
                lblQuestion.Text = "Quiz completed!";
                rdoOptionA.Visible = rdoOptionB.Visible = rdoOptionC.Visible = rdoOptionD.Visible = false;
                btnSubmitAnswer.Enabled = false;
                lblFeedback.Text = $"Final Score: {score}/{quizQuestions.Count}";
                return;
            }

            var q = quizQuestions[currentQuestionIndex];
            lblQuestion.Text = q.Question;
            rdoOptionA.Text = q.Options[0];
            rdoOptionB.Text = q.Options[1];
            rdoOptionC.Text = q.Options[2];
            rdoOptionD.Text = q.Options[3];

            // Ensure all are visible
            lblQuestion.Visible = true;
            rdoOptionA.Visible = rdoOptionB.Visible = rdoOptionC.Visible = rdoOptionD.Visible = true;
            btnSubmitAnswer.Visible = true;

            // Clear previous selections
            rdoOptionA.Checked = false;
            rdoOptionB.Checked = false;
            rdoOptionC.Checked = false;
            rdoOptionD.Checked = false;

            lblScore.Text = $"Score: {score}";
            lblFeedback.Text = "";
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            int selectedOption = -1;

            if (rdoOptionA.Checked) selectedOption = 0;
            else if (rdoOptionB.Checked) selectedOption = 1;
            else if (rdoOptionC.Checked) selectedOption = 2;
            else if (rdoOptionD.Checked) selectedOption = 3;

            if (selectedOption == -1)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            var currentQuestion = quizQuestions[currentQuestionIndex];

            string selectedAnswer = "";
            if (selectedOption >= 0 && selectedOption < currentQuestion.Options.Count)
                selectedAnswer = currentQuestion.Options[selectedOption];

            // Now add to activity log — both variables are in scope and initialized
            activityLog.Add($"Answered: '{currentQuestion.Question}' - Selected answer: '{selectedAnswer}' - Correct: {(selectedOption == currentQuestion.CorrectIndex ? "Yes" : "No")}");

            if (selectedOption == currentQuestion.CorrectIndex)
            {
                score++;
                lblFeedback.Text = "Correct! " + currentQuestion.Explanation;
            }
            else
            {
                lblFeedback.Text = "Incorrect! " + currentQuestion.Explanation;
            }

            currentQuestionIndex++;
            LoadQuestion();
        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtUserInput.Text.ToLower();

            // Display user input in chat
            AppendToChat($"You: {txtUserInput.Text}");

            // === NLP Simulated ===
            if (input.Contains("remind") && input.Contains("password"))
            {
                AppendToChat("Bot: Reminder set to update your password!");
                activityLog.Add("Reminder set for password update.");
            }
            else if ((input.Contains("add") && input.Contains("task")) || input.Contains("set a reminder"))
            {
                AppendToChat("Bot: What task would you like to add?");
                // Optional: Open task input fields
            }
            else if (input.Contains("quiz") || input.Contains("test my knowledge"))
            {
                AppendToChat("Bot: Launching cybersecurity quiz...");
                
                LoadQuestion();         // Start the quiz
                activityLog.Add("Cybersecurity quiz started.");
            }
            else if (input.Contains("activity log") || input.Contains("what have you done"))
            {
                btnShowLog_Click(null, null); 
            }

            else
            {
                AppendToChat("Bot: I'm still learning to understand that. Try rephrasing.");
            }

            txtUserInput.Clear();

        }

        private void AppendToChat(string message)
        {
            txtChatHistory.AppendText(message + Environment.NewLine);
        }


        private void btnShowLog_Click(object sender, EventArgs e)
        {
            lstActivityLog.Items.Clear();

            if (activityLog.Count == 0)
            {
                lstActivityLog.Items.Add("No activity recorded yet.");
                return;
            }

            var recent = activityLog.Skip(Math.Max(0, activityLog.Count - 10)).ToList();

            foreach (var log in recent)
            {
                lstActivityLog.Items.Add(log);
            }
        }






    }
}
