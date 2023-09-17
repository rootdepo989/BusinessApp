using App.DbOperations;
using App.DbOperations.Methods;
using App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.UI.Pages.Internet
{
    public partial class ElanAtlasiPage : Form
    {

        AppContextDb db = new AppContextDb();
        DateTime date = DateTime.Now;
        DialogResult alert;
        public ElanAtlasiPage()
        {
            InitializeComponent();
        }

        private void ElanAtlasiPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InternetDashboard internetDashboard = new InternetDashboard();
            internetDashboard.Show();
        }

        private void ElanAtlasiPage_Load(object sender, EventArgs e)
        {
            AnnouncementMethods.GetAllAnnouncements(dataGridViewOfAnnouncementPage,db);
        }

        // METHOD OF CLEAR ALL INPUTS.....
        private void ClearAllInputs()
        {
            textBoxNAME.Text = "";
            textBoxCategory.Text = "";
            textBoxTotalPayed.Text = "";
            textBoxTimeStarted.Text = "";
            textBoxTimeFinished.Text = "";
        }


        // ADD ANNONCEMENT EVENT....
        private void buttonADD_Click(object sender, EventArgs e)
        {
            Announcement announcement = new Announcement();

            string NAME = textBoxNAME.Text;
            string CATEGORY = textBoxCategory.Text;
            string PAYED = Convert.ToString(textBoxTotalPayed.Text);
            DateTime TIMESTART = Convert.ToDateTime(textBoxTimeStarted.Text);
            DateTime TIMEFINISHED = Convert.ToDateTime(textBoxTimeFinished.Text);


            try
            {
                AnnouncementMethods.AddAnnoncement( announcement, NAME, CATEGORY, PAYED, TIMESTART, TIMEFINISHED);
                db.Announcements.Add(announcement);
                db.SaveChanges();
                ClearAllInputs();
                AnnouncementMethods.GetAllAnnouncements(dataGridViewOfAnnouncementPage, db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // UPDATE OPERATIONS....
        private void buttonUPDATE_Click(object sender, EventArgs e)
        {


            string NAME = textBoxNAME.Text;
            string CATEGORY = textBoxCategory.Text;
            string PAYED = Convert.ToString(textBoxTotalPayed.Text);
            DateTime TIMESTART = Convert.ToDateTime(textBoxTimeStarted.Text);
            DateTime TIMEFINISHED = Convert.ToDateTime(textBoxTimeFinished.Text);

            try
            {
                int announcementId = Convert.ToInt32(dataGridViewOfAnnouncementPage.CurrentRow.Cells[0].Value.ToString());
                AnnouncementMethods.UpdateAnnoncement(announcementId, db, NAME, CATEGORY, PAYED, TIMESTART, TIMEFINISHED);
                AnnouncementMethods.GetAllAnnouncements(dataGridViewOfAnnouncementPage, db);
                ClearAllInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewOfAnnouncementPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select contact from inside from table rows...

            Announcement announcement = new Announcement();

            try
            {
                textBoxNAME.Text = dataGridViewOfAnnouncementPage.CurrentRow.Cells[1].Value.ToString();
                textBoxCategory.Text = dataGridViewOfAnnouncementPage.CurrentRow.Cells[2].Value.ToString();
                announcement.Ödənilən_Məbləğ = Convert.ToString(dataGridViewOfAnnouncementPage.CurrentRow.Cells[3].Value.ToString());
                announcement.Başlama_Müddəti = Convert.ToDateTime(dataGridViewOfAnnouncementPage.CurrentRow.Cells[4].Value.ToString());
                announcement.Bitmə_Müddəti = Convert.ToDateTime(dataGridViewOfAnnouncementPage.CurrentRow.Cells[5].Value.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // DELETE OPERATIONS....
        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                int annonuncementId = Convert.ToInt32(dataGridViewOfAnnouncementPage.CurrentRow.Cells[0].Value.ToString());
                DeleteAnnouncement(annonuncementId, dataGridViewOfAnnouncementPage, db);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
            // DELETE METHOD...
            private void DeleteAnnouncement(int annonuncementId, DataGridView dataGridView, AppContextDb db)
            {

                var name = dataGridView.CurrentRow.Cells[1].Value.ToString();

                Announcement announcement = db.Announcements.SingleOrDefault(a => a.Id == annonuncementId);

                alert = MessageBox.Show($"{name}    " + $"adındaki şəxsi silmək istədiyindən əminsən?", "İstifadəçi silinəcək!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (alert == DialogResult.Yes)
                {
                    db.Announcements.Remove(announcement);
                    db.SaveChanges();
                }
                AnnouncementMethods.GetAllAnnouncements(dataGridViewOfAnnouncementPage, db);
            }
        }
    }

