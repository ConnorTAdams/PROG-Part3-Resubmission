namespace POEPART3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Chat = new System.Windows.Forms.TabControl();
            this.tTaskAssistant = new System.Windows.Forms.TabPage();
            this.Quiz = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdoOptionA = new System.Windows.Forms.RadioButton();
            this.rdoOptionB = new System.Windows.Forms.RadioButton();
            this.rdoOptionC = new System.Windows.Forms.RadioButton();
            this.rdoOptionD = new System.Windows.Forms.RadioButton();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblBotResponse = new System.Windows.Forms.Label();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.lstActivityLog = new System.Windows.Forms.ListBox();
            this.txtChatHistory = new System.Windows.Forms.RichTextBox();
            this.Chat.SuspendLayout();
            this.tTaskAssistant.SuspendLayout();
            this.Quiz.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chat
            // 
            this.Chat.Controls.Add(this.tTaskAssistant);
            this.Chat.Controls.Add(this.Quiz);
            this.Chat.Controls.Add(this.tabPage3);
            this.Chat.Controls.Add(this.tabPage4);
            this.Chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chat.Location = new System.Drawing.Point(0, 0);
            this.Chat.Name = "Chat";
            this.Chat.SelectedIndex = 0;
            this.Chat.Size = new System.Drawing.Size(800, 450);
            this.Chat.TabIndex = 0;
            // 
            // tTaskAssistant
            // 
            this.tTaskAssistant.Controls.Add(this.label2);
            this.tTaskAssistant.Controls.Add(this.label1);
            this.tTaskAssistant.Controls.Add(this.lstTasks);
            this.tTaskAssistant.Controls.Add(this.btnAddTask);
            this.tTaskAssistant.Controls.Add(this.dtpReminder);
            this.tTaskAssistant.Controls.Add(this.txtTaskDescription);
            this.tTaskAssistant.Controls.Add(this.txtTaskTitle);
            this.tTaskAssistant.Location = new System.Drawing.Point(4, 25);
            this.tTaskAssistant.Name = "tTaskAssistant";
            this.tTaskAssistant.Padding = new System.Windows.Forms.Padding(3);
            this.tTaskAssistant.Size = new System.Drawing.Size(792, 421);
            this.tTaskAssistant.TabIndex = 0;
            this.tTaskAssistant.Text = "Task";
            this.tTaskAssistant.UseVisualStyleBackColor = true;
            // 
            // Quiz
            // 
            this.Quiz.Controls.Add(this.lblScore);
            this.Quiz.Controls.Add(this.lblFeedback);
            this.Quiz.Controls.Add(this.btnSubmitAnswer);
            this.Quiz.Controls.Add(this.rdoOptionD);
            this.Quiz.Controls.Add(this.rdoOptionC);
            this.Quiz.Controls.Add(this.rdoOptionB);
            this.Quiz.Controls.Add(this.rdoOptionA);
            this.Quiz.Controls.Add(this.lblQuestion);
            this.Quiz.Location = new System.Drawing.Point(4, 25);
            this.Quiz.Name = "Quiz";
            this.Quiz.Padding = new System.Windows.Forms.Padding(3);
            this.Quiz.Size = new System.Drawing.Size(792, 421);
            this.Quiz.TabIndex = 1;
            this.Quiz.Text = "Game";
            this.Quiz.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtChatHistory);
            this.tabPage3.Controls.Add(this.lblBotResponse);
            this.tabPage3.Controls.Add(this.btnSend);
            this.tabPage3.Controls.Add(this.txtUserInput);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chat";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstActivityLog);
            this.tabPage4.Controls.Add(this.btnShowLog);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(43, 57);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(383, 22);
            this.txtTaskTitle.TabIndex = 0;
            this.txtTaskTitle.TextChanged += new System.EventHandler(this.txtTaskTitle_TextChanged);
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(43, 129);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(383, 22);
            this.txtTaskDescription.TabIndex = 1;
            // 
            // dtpReminder
            // 
            this.dtpReminder.Location = new System.Drawing.Point(43, 200);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(263, 22);
            this.dtpReminder.TabIndex = 2;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(43, 286);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(182, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 16;
            this.lstTasks.Location = new System.Drawing.Point(370, 225);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(327, 148);
            this.lstTasks.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Task Description";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(23, 36);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(67, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Questions";
            // 
            // rdoOptionA
            // 
            this.rdoOptionA.AutoSize = true;
            this.rdoOptionA.Location = new System.Drawing.Point(167, 87);
            this.rdoOptionA.Name = "rdoOptionA";
            this.rdoOptionA.Size = new System.Drawing.Size(37, 20);
            this.rdoOptionA.TabIndex = 1;
            this.rdoOptionA.TabStop = true;
            this.rdoOptionA.Text = "A";
            this.rdoOptionA.UseVisualStyleBackColor = true;
            // 
            // rdoOptionB
            // 
            this.rdoOptionB.AutoSize = true;
            this.rdoOptionB.Location = new System.Drawing.Point(167, 134);
            this.rdoOptionB.Name = "rdoOptionB";
            this.rdoOptionB.Size = new System.Drawing.Size(37, 20);
            this.rdoOptionB.TabIndex = 2;
            this.rdoOptionB.TabStop = true;
            this.rdoOptionB.Text = "B";
            this.rdoOptionB.UseVisualStyleBackColor = true;
            // 
            // rdoOptionC
            // 
            this.rdoOptionC.AutoSize = true;
            this.rdoOptionC.Location = new System.Drawing.Point(167, 172);
            this.rdoOptionC.Name = "rdoOptionC";
            this.rdoOptionC.Size = new System.Drawing.Size(37, 20);
            this.rdoOptionC.TabIndex = 3;
            this.rdoOptionC.TabStop = true;
            this.rdoOptionC.Text = "C";
            this.rdoOptionC.UseVisualStyleBackColor = true;
            // 
            // rdoOptionD
            // 
            this.rdoOptionD.AutoSize = true;
            this.rdoOptionD.Location = new System.Drawing.Point(167, 212);
            this.rdoOptionD.Name = "rdoOptionD";
            this.rdoOptionD.Size = new System.Drawing.Size(38, 20);
            this.rdoOptionD.TabIndex = 4;
            this.rdoOptionD.TabStop = true;
            this.rdoOptionD.Text = "D";
            this.rdoOptionD.UseVisualStyleBackColor = true;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(602, 212);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(126, 23);
            this.btnSubmitAnswer.TabIndex = 5;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(47, 289);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(69, 16);
            this.lblFeedback.TabIndex = 6;
            this.lblFeedback.Text = "Feedback";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(47, 323);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(43, 16);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(26, 45);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(440, 22);
            this.txtUserInput.TabIndex = 0;
            this.txtUserInput.Text = "User: ";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(26, 102);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblBotResponse
            // 
            this.lblBotResponse.AutoSize = true;
            this.lblBotResponse.Location = new System.Drawing.Point(49, 165);
            this.lblBotResponse.Name = "lblBotResponse";
            this.lblBotResponse.Size = new System.Drawing.Size(0, 16);
            this.lblBotResponse.TabIndex = 2;
            // 
            // btnShowLog
            // 
            this.btnShowLog.Location = new System.Drawing.Point(164, 49);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(96, 36);
            this.btnShowLog.TabIndex = 0;
            this.btnShowLog.Text = "View Log";
            this.btnShowLog.UseVisualStyleBackColor = true;
            // 
            // lstActivityLog
            // 
            this.lstActivityLog.FormattingEnabled = true;
            this.lstActivityLog.ItemHeight = 16;
            this.lstActivityLog.Location = new System.Drawing.Point(24, 114);
            this.lstActivityLog.Name = "lstActivityLog";
            this.lstActivityLog.Size = new System.Drawing.Size(383, 196);
            this.lstActivityLog.TabIndex = 1;
            // 
            // txtChatHistory
            // 
            this.txtChatHistory.Location = new System.Drawing.Point(52, 180);
            this.txtChatHistory.Name = "txtChatHistory";
            this.txtChatHistory.Size = new System.Drawing.Size(394, 118);
            this.txtChatHistory.TabIndex = 3;
            this.txtChatHistory.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Chat);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Chat.ResumeLayout(false);
            this.tTaskAssistant.ResumeLayout(false);
            this.tTaskAssistant.PerformLayout();
            this.Quiz.ResumeLayout(false);
            this.Quiz.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Chat;
        private System.Windows.Forms.TabPage tTaskAssistant;
        private System.Windows.Forms.TabPage Quiz;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoOptionD;
        private System.Windows.Forms.RadioButton rdoOptionC;
        private System.Windows.Forms.RadioButton rdoOptionB;
        private System.Windows.Forms.RadioButton rdoOptionA;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblBotResponse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.ListBox lstActivityLog;
        private System.Windows.Forms.RichTextBox txtChatHistory;
    }
}

