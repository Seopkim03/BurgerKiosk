namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;

        public Form1()
        {
            InitializeComponent();

            // 프로그램 시작 시 초기화 함수 호출
            ResetSelection();
        }

        private void ResetSelection()
        {
            rdoBurger.Checked = false;
            rdoBulgogi.Checked = false;
            rdoChicken.Checked = false;

            totalCost = 0;
            UpdateTotalLabel();
        }

        // UI를 갱신하는 메서드
        private void UpdateTotalLabel()
        {
            lblTotal.Text = $"총 금액 : {totalCost:N0}원";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoBurger.Checked = false;
            rdoBulgogi.Checked = false;
            rdoChicken.Checked = false;
            chkChips.Checked = false;
            chkCoke.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();

            totalCost = 0; // 금액 변수도 초기화
            UpdateTotalLabel(); // 라벨 갱신
        }

        private void rdoBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else
            {
                totalCost -= 5000;
                lstOrder.Items.Remove("햄버거 5,000원");
            }
            UpdateTotalLabel(); // 변경된 금액 반영
        }

        private void rdoBulgogi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBulgogi.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else
            {
                totalCost -= 4000;
                lstOrder.Items.Remove("불고기버거 4,000원");
            }
            UpdateTotalLabel(); // 변경된 금액 반영
        }

        private void rdoChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChicken.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }
            else
            {
                totalCost -= 3000;
                lstOrder.Items.Remove("치킨버거 3,000원");
            }
            UpdateTotalLabel(); // 변경된 금액 반영
        }

        private void chkChips_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChips.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            else if (!chkChips.Checked)
            {
                totalCost -= 3500;
                lstOrder.Items.Remove("감자튀김 3,500원");
            }
            UpdateTotalLabel(); // 변경된 금액 반영
        }

        private void chkCoke_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoke.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            else if (!chkCoke.Checked)
            {
                totalCost -= 2500;
                lstOrder.Items.Remove("콜라 2,500원");
            }
            UpdateTotalLabel(); // 변경된 금액 반영
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            else if (!chkCheese.Checked)
            {
                totalCost -= 1500;
                lstOrder.Items.Remove("치즈 추가 1,500원");
            }
            UpdateTotalLabel(); // 변경된 금액 반영
        }

        private void chkSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }
            else if (!chkSauce.Checked)
            {
                totalCost -= 500;
                lstOrder.Items.Remove("소스 추가 500원");
            }
            UpdateTotalLabel(); // 변경된 금액 반영
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!rdoChicken.Checked && !rdoBulgogi.Checked && !rdoBurger.Checked)
            {
                lblTotal.Text = "메뉴를 선택해주세요.";
                return;
            }
            else {
                MessageBox.Show("주문이 완료되었습니다.", "주문 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rdoBurger.Checked = false;
                rdoBulgogi.Checked = false;
                rdoChicken.Checked = false;
                chkChips.Checked = false;
                chkCoke.Checked = false;
                chkCheese.Checked = false;
                chkSauce.Checked = false;
                lstOrder.Items.Clear();

                totalCost = 0; // 금액 변수도 초기화
                UpdateTotalLabel(); // 라벨 갱신
            }
        }
    }
}