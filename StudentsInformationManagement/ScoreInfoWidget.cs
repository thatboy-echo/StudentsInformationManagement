using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationManagement
{
    public partial class ScoreInfoWidget : UserControl
    {
        public ScoreInfoWidget()
        {
            InitializeComponent();
        }

        private Dictionary<string, double> scores;

        private void updateGridView()
        {
            scoreGridView.RowCount = scores.Count + (scoreGridView.AllowUserToAddRows ? 1 : 0);

            var keys = scores.Keys;
            for (int i = 0; i < scores.Count; i++)
            {
                scoreGridView[0, i].Value = keys.ElementAt(i);
                scoreGridView[1, i].Value = scores[keys.ElementAt(i)];
            }
        }
        public Dictionary<string, double> Scores
        {
            set
            {
                if(score!=null)
                    updateToScore();
                scores = value;
                updateGridView();
            }
        }

        public void updateToScore()
        {
            if(scores == null)
                return;
            scores.Clear();
            foreach (DataGridViewRow row in scoreGridView.Rows)
            {
                var prop = row.Cells[0].Value;
                if (prop != null)
                {

                    var value = row.Cells[1].Value;
                    if (value == null)
                        scores[prop.ToString()] = 0.0;
                    else
                    {
                        scores[prop.ToString()] = double.Parse(value.ToString());
                    }
                }
            }
        }
    }
}
