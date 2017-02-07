﻿namespace PokemonSunMoonRNGTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EggS_dataGridView = new System.Windows.Forms.DataGridView();
            this.dgv_EggS_Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_Used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_Seed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_Ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_Nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_PSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EggS_Rand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetSearchSeed = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetEggSeed = new System.Windows.Forms.ToolStripMenuItem();
            this.L_EggS_post = new System.Windows.Forms.Label();
            this.pre_parent1 = new System.Windows.Forms.NumericUpDown();
            this.L_EggS_pre = new System.Windows.Forms.Label();
            this.L_EggS_pre_H = new System.Windows.Forms.Label();
            this.post_parent1 = new System.Windows.Forms.NumericUpDown();
            this.post_parent2 = new System.Windows.Forms.NumericUpDown();
            this.post_parent3 = new System.Windows.Forms.NumericUpDown();
            this.post_parent4 = new System.Windows.Forms.NumericUpDown();
            this.post_parent5 = new System.Windows.Forms.NumericUpDown();
            this.post_parent6 = new System.Windows.Forms.NumericUpDown();
            this.pre_parent2 = new System.Windows.Forms.NumericUpDown();
            this.L_EggS_pre_A = new System.Windows.Forms.Label();
            this.pre_parent3 = new System.Windows.Forms.NumericUpDown();
            this.L_EggS_pre_B = new System.Windows.Forms.Label();
            this.pre_parent4 = new System.Windows.Forms.NumericUpDown();
            this.L_EggS_pre_C = new System.Windows.Forms.Label();
            this.pre_parent5 = new System.Windows.Forms.NumericUpDown();
            this.L_EggS_pre_D = new System.Windows.Forms.Label();
            this.pre_parent6 = new System.Windows.Forms.NumericUpDown();
            this.L_EggS_pre_S = new System.Windows.Forms.Label();
            this.pre_Items = new System.Windows.Forms.ComboBox();
            this.L_EggS_PreItems = new System.Windows.Forms.Label();
            this.L_EggS_post_H = new System.Windows.Forms.Label();
            this.L_EggS_post_A = new System.Windows.Forms.Label();
            this.L_EggS_post_B = new System.Windows.Forms.Label();
            this.L_EggS_post_C = new System.Windows.Forms.Label();
            this.L_EggS_post_D = new System.Windows.Forms.Label();
            this.L_EggS_post_S = new System.Windows.Forms.Label();
            this.post_Items = new System.Windows.Forms.ComboBox();
            this.L_EggS_PostItems = new System.Windows.Forms.Label();
            this.GB_EggS_Parents_Info = new System.Windows.Forms.GroupBox();
            this.CB_EggS_Heterogeneity = new System.Windows.Forms.CheckBox();
            this.CB_EggS_pre_ditto = new System.Windows.Forms.CheckBox();
            this.CB_EggS_post_ditto = new System.Windows.Forms.CheckBox();
            this.L_EggS_PostAbility = new System.Windows.Forms.Label();
            this.post_ability = new System.Windows.Forms.ComboBox();
            this.L_EggS_PreAbility = new System.Windows.Forms.Label();
            this.pre_ability = new System.Windows.Forms.ComboBox();
            this.sex_ratio = new System.Windows.Forms.ComboBox();
            this.L_EggS_Gender_ratio = new System.Windows.Forms.Label();
            this.CB_EggS_International = new System.Windows.Forms.CheckBox();
            this.GB_EggS_RNGInfo = new System.Windows.Forms.GroupBox();
            this.status3 = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.status2 = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.status1 = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.status0 = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.s_min = new System.Windows.Forms.NumericUpDown();
            this.s_max = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.L_EggS_Range = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.IVup2 = new System.Windows.Forms.NumericUpDown();
            this.label115 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.IVup3 = new System.Windows.Forms.NumericUpDown();
            this.IVup1 = new System.Windows.Forms.NumericUpDown();
            this.label113 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.IVup4 = new System.Windows.Forms.NumericUpDown();
            this.IVlow6 = new System.Windows.Forms.NumericUpDown();
            this.IVlow5 = new System.Windows.Forms.NumericUpDown();
            this.label110 = new System.Windows.Forms.Label();
            this.IVlow4 = new System.Windows.Forms.NumericUpDown();
            this.IVup5 = new System.Windows.Forms.NumericUpDown();
            this.IVlow3 = new System.Windows.Forms.NumericUpDown();
            this.IVlow2 = new System.Windows.Forms.NumericUpDown();
            this.label109 = new System.Windows.Forms.Label();
            this.IVlow1 = new System.Windows.Forms.NumericUpDown();
            this.L_EggS_Search_H = new System.Windows.Forms.Label();
            this.L_EggS_Search_A = new System.Windows.Forms.Label();
            this.L_EggS_Search_B = new System.Windows.Forms.Label();
            this.L_EggS_Search_C = new System.Windows.Forms.Label();
            this.L_EggS_Search_D = new System.Windows.Forms.Label();
            this.L_EggS_Search_S = new System.Windows.Forms.Label();
            this.mezapaType = new System.Windows.Forms.ComboBox();
            this.L_EggS_Search_HiddenPower = new System.Windows.Forms.Label();
            this.L_EggS_Search_Ability = new System.Windows.Forms.Label();
            this.ability = new System.Windows.Forms.ComboBox();
            this.L_EggS_Search_Gender = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.GB_EggS_Filters = new System.Windows.Forms.GroupBox();
            this.L_EggS_Search_Nature = new System.Windows.Forms.Label();
            this.nature = new System.Windows.Forms.ComboBox();
            this.CB_EggS_Search_DisableFilters = new System.Windows.Forms.CheckBox();
            this.L_EggS_Search_Ball = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.ComboBox();
            this.IVup6 = new System.Windows.Forms.NumericUpDown();
            this.B_EggS_Search = new System.Windows.Forms.Button();
            this.CB_EggS_ShinyCharm = new System.Windows.Forms.CheckBox();
            this.GB_EggS_SearchSettings = new System.Windows.Forms.GroupBox();
            this.TSV = new System.Windows.Forms.NumericUpDown();
            this.CB_EggS_OtherTSV = new System.Windows.Forms.CheckBox();
            this.CB_EggS_TSV_Shiny = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CB_EggS_Shiny = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_EggSearch = new System.Windows.Forms.TabPage();
            this.Tab_EggList = new System.Windows.Forms.TabPage();
            this.List_search = new System.Windows.Forms.Button();
            this.L_dataGridView = new System.Windows.Forms.DataGridView();
            this.dgvE_frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_seed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_psv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_ec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvE_rand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu2Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.L_RNGInfo = new System.Windows.Forms.GroupBox();
            this.Repeat_times = new System.Windows.Forms.Label();
            this.Target_frame = new System.Windows.Forms.NumericUpDown();
            this.L_targetframe = new System.Windows.Forms.Label();
            this.L_status3a = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.L_status2a = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.L_status1a = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.L_status0a = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.n_min = new System.Windows.Forms.NumericUpDown();
            this.n_max = new System.Windows.Forms.NumericUpDown();
            this.L_TSV_shiny = new System.Windows.Forms.CheckBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.L_eggrange = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_MainLanguage = new System.Windows.Forms.ToolStripComboBox();
            this.Menu_SaveConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_TSV = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ParentsList = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Tab_Stationary = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.Tab_StationarySearch = new System.Windows.Forms.TabPage();
            this.St_RNGInfo = new System.Windows.Forms.GroupBox();
            this.St_L_InitialSeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.St_UpdateFrame = new System.Windows.Forms.Button();
            this.St_L_TargetFrame = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.St_Frame = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.St_InitialSeed = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.St_min = new System.Windows.Forms.NumericUpDown();
            this.St_max = new System.Windows.Forms.NumericUpDown();
            this.St_TargetFrame = new System.Windows.Forms.NumericUpDown();
            this.St_TargetFrame_Range = new System.Windows.Forms.NumericUpDown();
            this.St_SearchSettings = new System.Windows.Forms.GroupBox();
            this.Valid_Blink = new System.Windows.Forms.CheckBox();
            this.St_SynchroOnly = new System.Windows.Forms.CheckBox();
            this.AlwaysSynchro = new System.Windows.Forms.CheckBox();
            this.St_TSV = new System.Windows.Forms.NumericUpDown();
            this.St_shiny = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.St_Filters = new System.Windows.Forms.GroupBox();
            this.St_stats6 = new System.Windows.Forms.NumericUpDown();
            this.St_stats3 = new System.Windows.Forms.NumericUpDown();
            this.St_stats4 = new System.Windows.Forms.NumericUpDown();
            this.St_stats5 = new System.Windows.Forms.NumericUpDown();
            this.St_stats2 = new System.Windows.Forms.NumericUpDown();
            this.St_stats1 = new System.Windows.Forms.NumericUpDown();
            this.synchro_nature = new System.Windows.Forms.Label();
            this.St_Invalid_Refine = new System.Windows.Forms.CheckBox();
            this.St_search_Status = new System.Windows.Forms.RadioButton();
            this.L_St_search_S = new System.Windows.Forms.Label();
            this.L_St_search_D = new System.Windows.Forms.Label();
            this.St_search_IV = new System.Windows.Forms.RadioButton();
            this.L_St_search_C = new System.Windows.Forms.Label();
            this.L_St_search_B = new System.Windows.Forms.Label();
            this.L_St_search_A = new System.Windows.Forms.Label();
            this.L_St_search_H = new System.Windows.Forms.Label();
            this.St_L_mezapa = new System.Windows.Forms.Label();
            this.St_pokedex = new System.Windows.Forms.ComboBox();
            this.St_Pokemon = new System.Windows.Forms.Label();
            this.St_mezapaType = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.St_Status_display = new System.Windows.Forms.CheckBox();
            this.St_Lv = new System.Windows.Forms.NumericUpDown();
            this.St_IVup6 = new System.Windows.Forms.NumericUpDown();
            this.St_IVlow1 = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.St_IVlow2 = new System.Windows.Forms.NumericUpDown();
            this.St_nature = new System.Windows.Forms.ComboBox();
            this.St_IVlow3 = new System.Windows.Forms.NumericUpDown();
            this.St_IVup5 = new System.Windows.Forms.NumericUpDown();
            this.St_IVlow4 = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.St_IVlow5 = new System.Windows.Forms.NumericUpDown();
            this.St_L_Nature = new System.Windows.Forms.Label();
            this.St_IVlow6 = new System.Windows.Forms.NumericUpDown();
            this.St_IVup4 = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.St_IVup1 = new System.Windows.Forms.NumericUpDown();
            this.St_IVup3 = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.St_IVup2 = new System.Windows.Forms.NumericUpDown();
            this.St_Synchro_nature = new System.Windows.Forms.ComboBox();
            this.Stationary_List = new System.Windows.Forms.Button();
            this.St_dataGridView = new System.Windows.Forms.DataGridView();
            this.dgvSt_frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_tolerance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_Synchronize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_H_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_A_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_B_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_C_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_D_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_S_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_psv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_Clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSt_rand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stationary_Search = new System.Windows.Forms.Button();
            this.Tab_StationaryClock = new System.Windows.Forms.TabPage();
            this.Calc_Frame_Info = new System.Windows.Forms.GroupBox();
            this.qty_NPC = new System.Windows.Forms.Label();
            this.NPC = new System.Windows.Forms.NumericUpDown();
            this.Calc_Output = new System.Windows.Forms.ListBox();
            this.Calc_Frame = new System.Windows.Forms.Button();
            this.Calc_InitialSeed = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.label24 = new System.Windows.Forms.Label();
            this.St_Clock_Time_Frame = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.St_Clock_Time_InitialSeed = new System.Windows.Forms.Label();
            this.Calc_min = new System.Windows.Forms.NumericUpDown();
            this.Calc_max = new System.Windows.Forms.NumericUpDown();
            this.Clock_RNGInfo = new System.Windows.Forms.GroupBox();
            this.Search_Clock = new System.Windows.Forms.ListBox();
            this.St_Clocklist = new System.Windows.Forms.Label();
            this.Clock_CurrentFrame = new System.Windows.Forms.Button();
            this.Clock_SearchList = new System.Windows.Forms.TextBox();
            this.Clock_InitialSeed = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.label17 = new System.Windows.Forms.Label();
            this.St_Clock_Search_Frame = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.St_Clock_Search_InitialSeed = new System.Windows.Forms.Label();
            this.Clock_min = new System.Windows.Forms.NumericUpDown();
            this.Clock_max = new System.Windows.Forms.NumericUpDown();
            this.Clock_groupBox = new System.Windows.Forms.GroupBox();
            this.TB_Candidate_InitSeed = new System.Windows.Forms.TextBox();
            this.L_Candidate_InitSeed = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Clock_List = new System.Windows.Forms.TextBox();
            this.clock_end = new System.Windows.Forms.RadioButton();
            this.clock_begin = new System.Windows.Forms.RadioButton();
            this.button_Clock_16 = new System.Windows.Forms.Button();
            this.button_Clock_15 = new System.Windows.Forms.Button();
            this.button_Clock_14 = new System.Windows.Forms.Button();
            this.button_Clock_13 = new System.Windows.Forms.Button();
            this.button_Clock_12 = new System.Windows.Forms.Button();
            this.button_Clock_11 = new System.Windows.Forms.Button();
            this.button_Clock_10 = new System.Windows.Forms.Button();
            this.button_Clock_9 = new System.Windows.Forms.Button();
            this.button_Clock_8 = new System.Windows.Forms.Button();
            this.button_Clock_7 = new System.Windows.Forms.Button();
            this.button_Clock_6 = new System.Windows.Forms.Button();
            this.button_Clock_5 = new System.Windows.Forms.Button();
            this.button_Clock_4 = new System.Windows.Forms.Button();
            this.button_Clock_3 = new System.Windows.Forms.Button();
            this.button_Clock_2 = new System.Windows.Forms.Button();
            this.button_Clock_1 = new System.Windows.Forms.Button();
            this.button_Clock_0 = new System.Windows.Forms.Button();
            this.Clock_3 = new System.Windows.Forms.Button();
            this.Clock_0 = new System.Windows.Forms.Button();
            this.Clock_16 = new System.Windows.Forms.Button();
            this.Clock_1 = new System.Windows.Forms.Button();
            this.Clock_15 = new System.Windows.Forms.Button();
            this.Clock_2 = new System.Windows.Forms.Button();
            this.Clock_14 = new System.Windows.Forms.Button();
            this.Clock_4 = new System.Windows.Forms.Button();
            this.Clock_13 = new System.Windows.Forms.Button();
            this.Clock_5 = new System.Windows.Forms.Button();
            this.Clock_12 = new System.Windows.Forms.Button();
            this.Clock_6 = new System.Windows.Forms.Button();
            this.Clock_11 = new System.Windows.Forms.Button();
            this.Clock_7 = new System.Windows.Forms.Button();
            this.Clock_10 = new System.Windows.Forms.Button();
            this.Clock_8 = new System.Windows.Forms.Button();
            this.Clock_9 = new System.Windows.Forms.Button();
            this.Tab_Egg = new System.Windows.Forms.TabPage();
            this.Tab_ID = new System.Windows.Forms.TabPage();
            this.ID_SearchSettings = new System.Windows.Forms.GroupBox();
            this.ID_L_CorrectionValue = new System.Windows.Forms.Label();
            this.Clock_CorrectionValue = new System.Windows.Forms.NumericUpDown();
            this.ID_Search = new System.Windows.Forms.Button();
            this.ID_dataGridView = new System.Windows.Forms.DataGridView();
            this.dgvID_frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID_TSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID_TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID_SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID_Clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Filters = new System.Windows.Forms.GroupBox();
            this.PartialMatch = new System.Windows.Forms.RadioButton();
            this.PerfectMatching = new System.Windows.Forms.RadioButton();
            this.ID_Invalid_Refine = new System.Windows.Forms.CheckBox();
            this.ID_List = new System.Windows.Forms.TextBox();
            this.L_ID_List = new System.Windows.Forms.Label();
            this.ID_PSVList = new System.Windows.Forms.TextBox();
            this.ID_shiny = new System.Windows.Forms.CheckBox();
            this.L_PSVList = new System.Windows.Forms.Label();
            this.ID_RNGInfo = new System.Windows.Forms.GroupBox();
            this.ID_L_InitialSeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_Frame = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ID_InitialSeed = new PokemonSunMoonRNGTool.HexNumericUpdown();
            this.ID_min = new System.Windows.Forms.NumericUpDown();
            this.ID_max = new System.Windows.Forms.NumericUpDown();
            this.other = new System.Windows.Forms.TabPage();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.EggS_dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent6)).BeginInit();
            this.GB_EggS_Parents_Info.SuspendLayout();
            this.GB_EggS_RNGInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow1)).BeginInit();
            this.GB_EggS_Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IVup6)).BeginInit();
            this.GB_EggS_SearchSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TSV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Tab_EggSearch.SuspendLayout();
            this.Tab_EggList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L_dataGridView)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.L_RNGInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Target_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_status3a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_status2a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_status1a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_status0a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_max)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Tab_Stationary.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.Tab_StationarySearch.SuspendLayout();
            this.St_RNGInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.St_InitialSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_TargetFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_TargetFrame_Range)).BeginInit();
            this.St_SearchSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.St_TSV)).BeginInit();
            this.St_Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_Lv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_dataGridView)).BeginInit();
            this.Tab_StationaryClock.SuspendLayout();
            this.Calc_Frame_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_InitialSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_max)).BeginInit();
            this.Clock_RNGInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_InitialSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_max)).BeginInit();
            this.Clock_groupBox.SuspendLayout();
            this.Tab_Egg.SuspendLayout();
            this.Tab_ID.SuspendLayout();
            this.ID_SearchSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_CorrectionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_dataGridView)).BeginInit();
            this.ID_Filters.SuspendLayout();
            this.ID_RNGInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_InitialSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_max)).BeginInit();
            this.SuspendLayout();
            // 
            // EggS_dataGridView
            // 
            this.EggS_dataGridView.AllowUserToAddRows = false;
            this.EggS_dataGridView.AllowUserToResizeColumns = false;
            this.EggS_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EggS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EggS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_EggS_Frame,
            this.dgv_EggS_Used,
            this.dgv_EggS_Seed,
            this.dgv_EggS_H,
            this.dgv_EggS_A,
            this.dgv_EggS_B,
            this.dgv_EggS_C,
            this.dgv_EggS_D,
            this.dgv_EggS_S,
            this.dgv_EggS_Gender,
            this.dgv_EggS_Ability,
            this.dgv_EggS_Nature,
            this.dgv_EggS_PID,
            this.dgv_EggS_PSV,
            this.dgv_EggS_EC,
            this.dgv_EggS_Rand});
            this.EggS_dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.EggS_dataGridView.Location = new System.Drawing.Point(6, 238);
            this.EggS_dataGridView.Name = "EggS_dataGridView";
            this.EggS_dataGridView.RowTemplate.Height = 21;
            this.EggS_dataGridView.Size = new System.Drawing.Size(1104, 258);
            this.EggS_dataGridView.TabIndex = 0;
            // 
            // dgv_EggS_Frame
            // 
            this.dgv_EggS_Frame.HeaderText = "消費";
            this.dgv_EggS_Frame.Name = "dgv_EggS_Frame";
            this.dgv_EggS_Frame.Width = 54;
            // 
            // dgv_EggS_Used
            // 
            this.dgv_EggS_Used.HeaderText = "受取";
            this.dgv_EggS_Used.Name = "dgv_EggS_Used";
            this.dgv_EggS_Used.Width = 54;
            // 
            // dgv_EggS_Seed
            // 
            this.dgv_EggS_Seed.HeaderText = "Seed";
            this.dgv_EggS_Seed.Name = "dgv_EggS_Seed";
            this.dgv_EggS_Seed.Width = 270;
            // 
            // dgv_EggS_H
            // 
            this.dgv_EggS_H.HeaderText = "H";
            this.dgv_EggS_H.Name = "dgv_EggS_H";
            this.dgv_EggS_H.Width = 27;
            // 
            // dgv_EggS_A
            // 
            this.dgv_EggS_A.HeaderText = "A";
            this.dgv_EggS_A.Name = "dgv_EggS_A";
            this.dgv_EggS_A.Width = 27;
            // 
            // dgv_EggS_B
            // 
            this.dgv_EggS_B.HeaderText = "B";
            this.dgv_EggS_B.Name = "dgv_EggS_B";
            this.dgv_EggS_B.Width = 27;
            // 
            // dgv_EggS_C
            // 
            this.dgv_EggS_C.HeaderText = "C";
            this.dgv_EggS_C.Name = "dgv_EggS_C";
            this.dgv_EggS_C.Width = 27;
            // 
            // dgv_EggS_D
            // 
            this.dgv_EggS_D.HeaderText = "D";
            this.dgv_EggS_D.Name = "dgv_EggS_D";
            this.dgv_EggS_D.Width = 27;
            // 
            // dgv_EggS_S
            // 
            this.dgv_EggS_S.HeaderText = "S";
            this.dgv_EggS_S.Name = "dgv_EggS_S";
            this.dgv_EggS_S.Width = 27;
            // 
            // dgv_EggS_Gender
            // 
            this.dgv_EggS_Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_EggS_Gender.HeaderText = "性別";
            this.dgv_EggS_Gender.Name = "dgv_EggS_Gender";
            this.dgv_EggS_Gender.Width = 54;
            // 
            // dgv_EggS_Ability
            // 
            this.dgv_EggS_Ability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_EggS_Ability.HeaderText = "特性";
            this.dgv_EggS_Ability.Name = "dgv_EggS_Ability";
            this.dgv_EggS_Ability.Width = 54;
            // 
            // dgv_EggS_Nature
            // 
            this.dgv_EggS_Nature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_EggS_Nature.HeaderText = "性格";
            this.dgv_EggS_Nature.Name = "dgv_EggS_Nature";
            this.dgv_EggS_Nature.Width = 54;
            // 
            // dgv_EggS_PID
            // 
            this.dgv_EggS_PID.HeaderText = "性格値";
            this.dgv_EggS_PID.Name = "dgv_EggS_PID";
            this.dgv_EggS_PID.Width = 66;
            // 
            // dgv_EggS_PSV
            // 
            this.dgv_EggS_PSV.HeaderText = "SV";
            this.dgv_EggS_PSV.Name = "dgv_EggS_PSV";
            this.dgv_EggS_PSV.Width = 54;
            // 
            // dgv_EggS_EC
            // 
            this.dgv_EggS_EC.HeaderText = "暗号化定数";
            this.dgv_EggS_EC.Name = "dgv_EggS_EC";
            this.dgv_EggS_EC.Width = 90;
            // 
            // dgv_EggS_Rand
            // 
            this.dgv_EggS_Rand.HeaderText = "乱数列";
            this.dgv_EggS_Rand.Name = "dgv_EggS_Rand";
            this.dgv_EggS_Rand.Width = 66;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopy,
            this.mnuSelectAll,
            this.mnuSetSearchSeed,
            this.mnuSetEggSeed});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 92);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(224, 22);
            this.mnuCopy.Text = "コピー";
            this.mnuCopy.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.Size = new System.Drawing.Size(224, 22);
            this.mnuSelectAll.Text = "全て選択";
            this.mnuSelectAll.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // mnuSetSearchSeed
            // 
            this.mnuSetSearchSeed.Name = "mnuSetSearchSeed";
            this.mnuSetSearchSeed.Size = new System.Drawing.Size(224, 22);
            this.mnuSetSearchSeed.Text = "検索範囲へseedを入れる";
            this.mnuSetSearchSeed.Click += new System.EventHandler(this.Send2SearchSeed);
            // 
            // mnuSetEggSeed
            // 
            this.mnuSetEggSeed.Name = "mnuSetEggSeed";
            this.mnuSetEggSeed.Size = new System.Drawing.Size(224, 22);
            this.mnuSetEggSeed.Text = "連続孵化リストへseedを入れる";
            this.mnuSetEggSeed.Click += new System.EventHandler(this.Send2List);
            // 
            // L_EggS_post
            // 
            this.L_EggS_post.ForeColor = System.Drawing.Color.Red;
            this.L_EggS_post.Location = new System.Drawing.Point(0, 111);
            this.L_EggS_post.Name = "L_EggS_post";
            this.L_EggS_post.Size = new System.Drawing.Size(65, 18);
            this.L_EggS_post.TabIndex = 124;
            this.L_EggS_post.Text = "♀親";
            this.L_EggS_post.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.L_EggS_post.DoubleClick += new System.EventHandler(this.Change_color);
            // 
            // pre_parent1
            // 
            this.pre_parent1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_parent1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pre_parent1.Location = new System.Drawing.Point(57, 38);
            this.pre_parent1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent1.Name = "pre_parent1";
            this.pre_parent1.Size = new System.Drawing.Size(45, 22);
            this.pre_parent1.TabIndex = 1;
            this.pre_parent1.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.pre_parent1.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_EggS_pre
            // 
            this.L_EggS_pre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.L_EggS_pre.Location = new System.Drawing.Point(-1, 19);
            this.L_EggS_pre.Name = "L_EggS_pre";
            this.L_EggS_pre.Size = new System.Drawing.Size(65, 18);
            this.L_EggS_pre.TabIndex = 9;
            this.L_EggS_pre.Text = "♂親";
            this.L_EggS_pre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.L_EggS_pre.DoubleClick += new System.EventHandler(this.Change_color);
            // 
            // L_EggS_pre_H
            // 
            this.L_EggS_pre_H.AutoSize = true;
            this.L_EggS_pre_H.Location = new System.Drawing.Point(73, 23);
            this.L_EggS_pre_H.Name = "L_EggS_pre_H";
            this.L_EggS_pre_H.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_pre_H.TabIndex = 12;
            this.L_EggS_pre_H.Text = "H";
            // 
            // post_parent1
            // 
            this.post_parent1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_parent1.ForeColor = System.Drawing.Color.Red;
            this.post_parent1.Location = new System.Drawing.Point(58, 129);
            this.post_parent1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent1.Name = "post_parent1";
            this.post_parent1.Size = new System.Drawing.Size(45, 22);
            this.post_parent1.TabIndex = 7;
            this.post_parent1.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.post_parent1.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // post_parent2
            // 
            this.post_parent2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_parent2.ForeColor = System.Drawing.Color.Red;
            this.post_parent2.Location = new System.Drawing.Point(109, 129);
            this.post_parent2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent2.Name = "post_parent2";
            this.post_parent2.Size = new System.Drawing.Size(45, 22);
            this.post_parent2.TabIndex = 8;
            this.post_parent2.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.post_parent2.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // post_parent3
            // 
            this.post_parent3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_parent3.ForeColor = System.Drawing.Color.Red;
            this.post_parent3.Location = new System.Drawing.Point(160, 129);
            this.post_parent3.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent3.Name = "post_parent3";
            this.post_parent3.Size = new System.Drawing.Size(45, 22);
            this.post_parent3.TabIndex = 9;
            this.post_parent3.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent3.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.post_parent3.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // post_parent4
            // 
            this.post_parent4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_parent4.ForeColor = System.Drawing.Color.Red;
            this.post_parent4.Location = new System.Drawing.Point(211, 129);
            this.post_parent4.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent4.Name = "post_parent4";
            this.post_parent4.Size = new System.Drawing.Size(45, 22);
            this.post_parent4.TabIndex = 10;
            this.post_parent4.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent4.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.post_parent4.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // post_parent5
            // 
            this.post_parent5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_parent5.ForeColor = System.Drawing.Color.Red;
            this.post_parent5.Location = new System.Drawing.Point(262, 129);
            this.post_parent5.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent5.Name = "post_parent5";
            this.post_parent5.Size = new System.Drawing.Size(45, 22);
            this.post_parent5.TabIndex = 11;
            this.post_parent5.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent5.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.post_parent5.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // post_parent6
            // 
            this.post_parent6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_parent6.ForeColor = System.Drawing.Color.Red;
            this.post_parent6.Location = new System.Drawing.Point(312, 129);
            this.post_parent6.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent6.Name = "post_parent6";
            this.post_parent6.Size = new System.Drawing.Size(45, 22);
            this.post_parent6.TabIndex = 12;
            this.post_parent6.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.post_parent6.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.post_parent6.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // pre_parent2
            // 
            this.pre_parent2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_parent2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pre_parent2.Location = new System.Drawing.Point(108, 38);
            this.pre_parent2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent2.Name = "pre_parent2";
            this.pre_parent2.Size = new System.Drawing.Size(45, 22);
            this.pre_parent2.TabIndex = 2;
            this.pre_parent2.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.pre_parent2.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_EggS_pre_A
            // 
            this.L_EggS_pre_A.AutoSize = true;
            this.L_EggS_pre_A.Location = new System.Drawing.Point(124, 23);
            this.L_EggS_pre_A.Name = "L_EggS_pre_A";
            this.L_EggS_pre_A.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_pre_A.TabIndex = 131;
            this.L_EggS_pre_A.Text = "A";
            // 
            // pre_parent3
            // 
            this.pre_parent3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_parent3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pre_parent3.Location = new System.Drawing.Point(159, 38);
            this.pre_parent3.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent3.Name = "pre_parent3";
            this.pre_parent3.Size = new System.Drawing.Size(45, 22);
            this.pre_parent3.TabIndex = 3;
            this.pre_parent3.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent3.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.pre_parent3.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_EggS_pre_B
            // 
            this.L_EggS_pre_B.AutoSize = true;
            this.L_EggS_pre_B.Location = new System.Drawing.Point(175, 23);
            this.L_EggS_pre_B.Name = "L_EggS_pre_B";
            this.L_EggS_pre_B.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_pre_B.TabIndex = 133;
            this.L_EggS_pre_B.Text = "B";
            // 
            // pre_parent4
            // 
            this.pre_parent4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_parent4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pre_parent4.Location = new System.Drawing.Point(210, 38);
            this.pre_parent4.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent4.Name = "pre_parent4";
            this.pre_parent4.Size = new System.Drawing.Size(45, 22);
            this.pre_parent4.TabIndex = 4;
            this.pre_parent4.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent4.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.pre_parent4.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_EggS_pre_C
            // 
            this.L_EggS_pre_C.AutoSize = true;
            this.L_EggS_pre_C.Location = new System.Drawing.Point(226, 23);
            this.L_EggS_pre_C.Name = "L_EggS_pre_C";
            this.L_EggS_pre_C.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_pre_C.TabIndex = 135;
            this.L_EggS_pre_C.Text = "C";
            // 
            // pre_parent5
            // 
            this.pre_parent5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_parent5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pre_parent5.Location = new System.Drawing.Point(261, 38);
            this.pre_parent5.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent5.Name = "pre_parent5";
            this.pre_parent5.Size = new System.Drawing.Size(45, 22);
            this.pre_parent5.TabIndex = 5;
            this.pre_parent5.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent5.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.pre_parent5.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_EggS_pre_D
            // 
            this.L_EggS_pre_D.AutoSize = true;
            this.L_EggS_pre_D.Location = new System.Drawing.Point(277, 23);
            this.L_EggS_pre_D.Name = "L_EggS_pre_D";
            this.L_EggS_pre_D.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_pre_D.TabIndex = 137;
            this.L_EggS_pre_D.Text = "D";
            // 
            // pre_parent6
            // 
            this.pre_parent6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_parent6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pre_parent6.Location = new System.Drawing.Point(312, 38);
            this.pre_parent6.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent6.Name = "pre_parent6";
            this.pre_parent6.Size = new System.Drawing.Size(45, 22);
            this.pre_parent6.TabIndex = 6;
            this.pre_parent6.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pre_parent6.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.pre_parent6.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_EggS_pre_S
            // 
            this.L_EggS_pre_S.AutoSize = true;
            this.L_EggS_pre_S.Location = new System.Drawing.Point(328, 23);
            this.L_EggS_pre_S.Name = "L_EggS_pre_S";
            this.L_EggS_pre_S.Size = new System.Drawing.Size(12, 12);
            this.L_EggS_pre_S.TabIndex = 139;
            this.L_EggS_pre_S.Text = "S";
            // 
            // pre_Items
            // 
            this.pre_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pre_Items.FormattingEnabled = true;
            this.pre_Items.Items.AddRange(new object[] {
            "指定なし",
            "変わらず",
            "赤い糸",
            "H-パワーウエイト",
            "A-パワーリスト",
            "B-パワーベルト",
            "C-パワーレンズ",
            "D-パワーバンド",
            "S-パワーアンクル"});
            this.pre_Items.Location = new System.Drawing.Point(75, 75);
            this.pre_Items.Name = "pre_Items";
            this.pre_Items.Size = new System.Drawing.Size(100, 20);
            this.pre_Items.TabIndex = 13;
            // 
            // L_EggS_PreItems
            // 
            this.L_EggS_PreItems.Location = new System.Drawing.Point(6, 76);
            this.L_EggS_PreItems.Name = "L_EggS_PreItems";
            this.L_EggS_PreItems.Size = new System.Drawing.Size(63, 18);
            this.L_EggS_PreItems.TabIndex = 153;
            this.L_EggS_PreItems.Text = "持ち物";
            this.L_EggS_PreItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_EggS_post_H
            // 
            this.L_EggS_post_H.AutoSize = true;
            this.L_EggS_post_H.Location = new System.Drawing.Point(73, 114);
            this.L_EggS_post_H.Name = "L_EggS_post_H";
            this.L_EggS_post_H.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_post_H.TabIndex = 156;
            this.L_EggS_post_H.Text = "H";
            // 
            // L_EggS_post_A
            // 
            this.L_EggS_post_A.AutoSize = true;
            this.L_EggS_post_A.Location = new System.Drawing.Point(124, 114);
            this.L_EggS_post_A.Name = "L_EggS_post_A";
            this.L_EggS_post_A.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_post_A.TabIndex = 157;
            this.L_EggS_post_A.Text = "A";
            // 
            // L_EggS_post_B
            // 
            this.L_EggS_post_B.AutoSize = true;
            this.L_EggS_post_B.Location = new System.Drawing.Point(175, 114);
            this.L_EggS_post_B.Name = "L_EggS_post_B";
            this.L_EggS_post_B.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_post_B.TabIndex = 158;
            this.L_EggS_post_B.Text = "B";
            // 
            // L_EggS_post_C
            // 
            this.L_EggS_post_C.AutoSize = true;
            this.L_EggS_post_C.Location = new System.Drawing.Point(226, 114);
            this.L_EggS_post_C.Name = "L_EggS_post_C";
            this.L_EggS_post_C.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_post_C.TabIndex = 159;
            this.L_EggS_post_C.Text = "C";
            // 
            // L_EggS_post_D
            // 
            this.L_EggS_post_D.AutoSize = true;
            this.L_EggS_post_D.Location = new System.Drawing.Point(277, 114);
            this.L_EggS_post_D.Name = "L_EggS_post_D";
            this.L_EggS_post_D.Size = new System.Drawing.Size(13, 12);
            this.L_EggS_post_D.TabIndex = 160;
            this.L_EggS_post_D.Text = "D";
            // 
            // L_EggS_post_S
            // 
            this.L_EggS_post_S.AutoSize = true;
            this.L_EggS_post_S.Location = new System.Drawing.Point(328, 114);
            this.L_EggS_post_S.Name = "L_EggS_post_S";
            this.L_EggS_post_S.Size = new System.Drawing.Size(12, 12);
            this.L_EggS_post_S.TabIndex = 161;
            this.L_EggS_post_S.Text = "S";
            // 
            // post_Items
            // 
            this.post_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.post_Items.FormattingEnabled = true;
            this.post_Items.Items.AddRange(new object[] {
            "指定なし",
            "変わらず",
            "赤い糸",
            "H-パワーウエイト",
            "A-パワーリスト",
            "B-パワーベルト",
            "C-パワーレンズ",
            "D-パワーバンド",
            "S-パワーアンクル"});
            this.post_Items.Location = new System.Drawing.Point(75, 166);
            this.post_Items.Name = "post_Items";
            this.post_Items.Size = new System.Drawing.Size(100, 20);
            this.post_Items.TabIndex = 16;
            // 
            // L_EggS_PostItems
            // 
            this.L_EggS_PostItems.Location = new System.Drawing.Point(6, 167);
            this.L_EggS_PostItems.Name = "L_EggS_PostItems";
            this.L_EggS_PostItems.Size = new System.Drawing.Size(64, 18);
            this.L_EggS_PostItems.TabIndex = 173;
            this.L_EggS_PostItems.Text = "持ち物";
            this.L_EggS_PostItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GB_EggS_Parents_Info
            // 
            this.GB_EggS_Parents_Info.Controls.Add(this.CB_EggS_Heterogeneity);
            this.GB_EggS_Parents_Info.Controls.Add(this.CB_EggS_pre_ditto);
            this.GB_EggS_Parents_Info.Controls.Add(this.CB_EggS_post_ditto);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_PostAbility);
            this.GB_EggS_Parents_Info.Controls.Add(this.post_ability);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_PreAbility);
            this.GB_EggS_Parents_Info.Controls.Add(this.pre_ability);
            this.GB_EggS_Parents_Info.Controls.Add(this.sex_ratio);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_Gender_ratio);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_PostItems);
            this.GB_EggS_Parents_Info.Controls.Add(this.post_Items);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_post_S);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_post_D);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_post_C);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_post_B);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_post_A);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_post_H);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_PreItems);
            this.GB_EggS_Parents_Info.Controls.Add(this.pre_Items);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_pre_S);
            this.GB_EggS_Parents_Info.Controls.Add(this.pre_parent6);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_pre_D);
            this.GB_EggS_Parents_Info.Controls.Add(this.pre_parent5);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_pre_C);
            this.GB_EggS_Parents_Info.Controls.Add(this.pre_parent4);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_pre_B);
            this.GB_EggS_Parents_Info.Controls.Add(this.pre_parent3);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_pre_A);
            this.GB_EggS_Parents_Info.Controls.Add(this.pre_parent2);
            this.GB_EggS_Parents_Info.Controls.Add(this.post_parent6);
            this.GB_EggS_Parents_Info.Controls.Add(this.post_parent5);
            this.GB_EggS_Parents_Info.Controls.Add(this.post_parent4);
            this.GB_EggS_Parents_Info.Controls.Add(this.post_parent3);
            this.GB_EggS_Parents_Info.Controls.Add(this.post_parent2);
            this.GB_EggS_Parents_Info.Controls.Add(this.post_parent1);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_pre_H);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_pre);
            this.GB_EggS_Parents_Info.Controls.Add(this.pre_parent1);
            this.GB_EggS_Parents_Info.Controls.Add(this.L_EggS_post);
            this.GB_EggS_Parents_Info.Location = new System.Drawing.Point(6, 6);
            this.GB_EggS_Parents_Info.Name = "GB_EggS_Parents_Info";
            this.GB_EggS_Parents_Info.Size = new System.Drawing.Size(369, 226);
            this.GB_EggS_Parents_Info.TabIndex = 2;
            this.GB_EggS_Parents_Info.TabStop = false;
            this.GB_EggS_Parents_Info.Text = "親の情報";
            // 
            // CB_EggS_Heterogeneity
            // 
            this.CB_EggS_Heterogeneity.AutoSize = true;
            this.CB_EggS_Heterogeneity.Location = new System.Drawing.Point(33, 199);
            this.CB_EggS_Heterogeneity.Name = "CB_EggS_Heterogeneity";
            this.CB_EggS_Heterogeneity.Size = new System.Drawing.Size(84, 16);
            this.CB_EggS_Heterogeneity.TabIndex = 179;
            this.CB_EggS_Heterogeneity.Text = "異種間孵化";
            this.CB_EggS_Heterogeneity.UseVisualStyleBackColor = true;
            // 
            // CB_EggS_pre_ditto
            // 
            this.CB_EggS_pre_ditto.AutoSize = true;
            this.CB_EggS_pre_ditto.Location = new System.Drawing.Point(293, 77);
            this.CB_EggS_pre_ditto.Name = "CB_EggS_pre_ditto";
            this.CB_EggS_pre_ditto.Size = new System.Drawing.Size(58, 16);
            this.CB_EggS_pre_ditto.TabIndex = 15;
            this.CB_EggS_pre_ditto.Text = "メタモン";
            this.CB_EggS_pre_ditto.UseVisualStyleBackColor = true;
            this.CB_EggS_pre_ditto.CheckedChanged += new System.EventHandler(this.Change_ditto);
            // 
            // CB_EggS_post_ditto
            // 
            this.CB_EggS_post_ditto.AutoSize = true;
            this.CB_EggS_post_ditto.Location = new System.Drawing.Point(293, 168);
            this.CB_EggS_post_ditto.Name = "CB_EggS_post_ditto";
            this.CB_EggS_post_ditto.Size = new System.Drawing.Size(58, 16);
            this.CB_EggS_post_ditto.TabIndex = 18;
            this.CB_EggS_post_ditto.Text = "メタモン";
            this.CB_EggS_post_ditto.UseVisualStyleBackColor = true;
            this.CB_EggS_post_ditto.CheckedChanged += new System.EventHandler(this.Change_ditto);
            // 
            // L_EggS_PostAbility
            // 
            this.L_EggS_PostAbility.Location = new System.Drawing.Point(181, 167);
            this.L_EggS_PostAbility.Name = "L_EggS_PostAbility";
            this.L_EggS_PostAbility.Size = new System.Drawing.Size(42, 18);
            this.L_EggS_PostAbility.TabIndex = 178;
            this.L_EggS_PostAbility.Text = "特性";
            this.L_EggS_PostAbility.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // post_ability
            // 
            this.post_ability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.post_ability.FormattingEnabled = true;
            this.post_ability.Items.AddRange(new object[] {
            "1",
            "2",
            "夢"});
            this.post_ability.Location = new System.Drawing.Point(226, 166);
            this.post_ability.Name = "post_ability";
            this.post_ability.Size = new System.Drawing.Size(45, 20);
            this.post_ability.TabIndex = 17;
            // 
            // L_EggS_PreAbility
            // 
            this.L_EggS_PreAbility.Location = new System.Drawing.Point(181, 76);
            this.L_EggS_PreAbility.Name = "L_EggS_PreAbility";
            this.L_EggS_PreAbility.Size = new System.Drawing.Size(42, 18);
            this.L_EggS_PreAbility.TabIndex = 176;
            this.L_EggS_PreAbility.Text = "特性";
            this.L_EggS_PreAbility.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pre_ability
            // 
            this.pre_ability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pre_ability.FormattingEnabled = true;
            this.pre_ability.Items.AddRange(new object[] {
            "1",
            "2",
            "夢"});
            this.pre_ability.Location = new System.Drawing.Point(226, 75);
            this.pre_ability.Name = "pre_ability";
            this.pre_ability.Size = new System.Drawing.Size(45, 20);
            this.pre_ability.TabIndex = 14;
            // 
            // sex_ratio
            // 
            this.sex_ratio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex_ratio.FormattingEnabled = true;
            this.sex_ratio.Items.AddRange(new object[] {
            "♂1：♀1",
            "♂7：♀1",
            "♂3：♀1",
            "♂1：♀3",
            "♂のみ",
            "♀のみ",
            "無性別"});
            this.sex_ratio.Location = new System.Drawing.Point(273, 197);
            this.sex_ratio.Name = "sex_ratio";
            this.sex_ratio.Size = new System.Drawing.Size(80, 20);
            this.sex_ratio.TabIndex = 20;
            // 
            // L_EggS_Gender_ratio
            // 
            this.L_EggS_Gender_ratio.Location = new System.Drawing.Point(159, 198);
            this.L_EggS_Gender_ratio.Name = "L_EggS_Gender_ratio";
            this.L_EggS_Gender_ratio.Size = new System.Drawing.Size(108, 18);
            this.L_EggS_Gender_ratio.TabIndex = 122;
            this.L_EggS_Gender_ratio.Text = "性別比";
            this.L_EggS_Gender_ratio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CB_EggS_International
            // 
            this.CB_EggS_International.AutoSize = true;
            this.CB_EggS_International.Location = new System.Drawing.Point(22, 27);
            this.CB_EggS_International.Name = "CB_EggS_International";
            this.CB_EggS_International.Size = new System.Drawing.Size(72, 16);
            this.CB_EggS_International.TabIndex = 52;
            this.CB_EggS_International.Text = "国際孵化";
            this.CB_EggS_International.UseVisualStyleBackColor = true;
            // 
            // GB_EggS_RNGInfo
            // 
            this.GB_EggS_RNGInfo.Controls.Add(this.status3);
            this.GB_EggS_RNGInfo.Controls.Add(this.status2);
            this.GB_EggS_RNGInfo.Controls.Add(this.status1);
            this.GB_EggS_RNGInfo.Controls.Add(this.status0);
            this.GB_EggS_RNGInfo.Controls.Add(this.s_min);
            this.GB_EggS_RNGInfo.Controls.Add(this.s_max);
            this.GB_EggS_RNGInfo.Controls.Add(this.label13);
            this.GB_EggS_RNGInfo.Controls.Add(this.label14);
            this.GB_EggS_RNGInfo.Controls.Add(this.label11);
            this.GB_EggS_RNGInfo.Controls.Add(this.label12);
            this.GB_EggS_RNGInfo.Controls.Add(this.label1);
            this.GB_EggS_RNGInfo.Controls.Add(this.label9);
            this.GB_EggS_RNGInfo.Controls.Add(this.label16);
            this.GB_EggS_RNGInfo.Controls.Add(this.label15);
            this.GB_EggS_RNGInfo.Controls.Add(this.L_EggS_Range);
            this.GB_EggS_RNGInfo.Controls.Add(this.label176);
            this.GB_EggS_RNGInfo.Location = new System.Drawing.Point(697, 6);
            this.GB_EggS_RNGInfo.Name = "GB_EggS_RNGInfo";
            this.GB_EggS_RNGInfo.Size = new System.Drawing.Size(223, 226);
            this.GB_EggS_RNGInfo.TabIndex = 3;
            this.GB_EggS_RNGInfo.TabStop = false;
            this.GB_EggS_RNGInfo.Text = "検索範囲";
            // 
            // status3
            // 
            this.status3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status3.Hexadecimal = true;
            this.status3.Location = new System.Drawing.Point(118, 24);
            this.status3.Name = "status3";
            this.status3.Size = new System.Drawing.Size(80, 22);
            this.status3.TabIndex = 70;
            this.status3.Value = new decimal(new int[] {
            305419896,
            0,
            0,
            0});
            this.status3.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.status3.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // status2
            // 
            this.status2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status2.Hexadecimal = true;
            this.status2.Location = new System.Drawing.Point(118, 52);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(80, 22);
            this.status2.TabIndex = 71;
            this.status2.Value = new decimal(new int[] {
            -559023410,
            0,
            0,
            0});
            this.status2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.status2.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // status1
            // 
            this.status1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status1.Hexadecimal = true;
            this.status1.Location = new System.Drawing.Point(118, 80);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(80, 22);
            this.status1.TabIndex = 72;
            this.status1.Value = new decimal(new int[] {
            -559038737,
            0,
            0,
            0});
            this.status1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.status1.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // status0
            // 
            this.status0.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status0.Hexadecimal = true;
            this.status0.Location = new System.Drawing.Point(118, 108);
            this.status0.Name = "status0";
            this.status0.Size = new System.Drawing.Size(80, 22);
            this.status0.TabIndex = 73;
            this.status0.Value = new decimal(new int[] {
            -1091568946,
            0,
            0,
            0});
            this.status0.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.status0.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // s_min
            // 
            this.s_min.Font = new System.Drawing.Font("Consolas", 9F);
            this.s_min.Location = new System.Drawing.Point(20, 175);
            this.s_min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.s_min.Name = "s_min";
            this.s_min.Size = new System.Drawing.Size(80, 22);
            this.s_min.TabIndex = 78;
            this.s_min.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.s_min.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // s_max
            // 
            this.s_max.Font = new System.Drawing.Font("Consolas", 9F);
            this.s_max.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.s_max.Location = new System.Drawing.Point(130, 175);
            this.s_max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.s_max.Name = "s_max";
            this.s_max.Size = new System.Drawing.Size(80, 22);
            this.s_max.TabIndex = 79;
            this.s_max.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.s_max.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.s_max.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 9F);
            this.label13.Location = new System.Drawing.Point(15, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 14);
            this.label13.TabIndex = 77;
            this.label13.Text = "status[0]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(91, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 14);
            this.label14.TabIndex = 76;
            this.label14.Text = "0x";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9F);
            this.label11.Location = new System.Drawing.Point(15, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 74;
            this.label11.Text = "status[1]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(91, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 14);
            this.label12.TabIndex = 73;
            this.label12.Text = "0x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F);
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 71;
            this.label1.Text = "status[2]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 14);
            this.label9.TabIndex = 70;
            this.label9.Text = "0x";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 9F);
            this.label16.Location = new System.Drawing.Point(15, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 14);
            this.label16.TabIndex = 68;
            this.label16.Text = "status[3]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(91, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 14);
            this.label15.TabIndex = 67;
            this.label15.Text = "0x";
            // 
            // L_EggS_Range
            // 
            this.L_EggS_Range.AutoSize = true;
            this.L_EggS_Range.Location = new System.Drawing.Point(18, 152);
            this.L_EggS_Range.Name = "L_EggS_Range";
            this.L_EggS_Range.Size = new System.Drawing.Size(41, 12);
            this.L_EggS_Range.TabIndex = 64;
            this.L_EggS_Range.Text = "消費数";
            // 
            // label176
            // 
            this.label176.Location = new System.Drawing.Point(106, 180);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(18, 16);
            this.label176.TabIndex = 61;
            this.label176.Text = "～";
            // 
            // IVup2
            // 
            this.IVup2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVup2.Location = new System.Drawing.Point(112, 57);
            this.IVup2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup2.Name = "IVup2";
            this.IVup2.Size = new System.Drawing.Size(45, 22);
            this.IVup2.TabIndex = 28;
            this.IVup2.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVup2.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(92, 94);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(17, 12);
            this.label115.TabIndex = 80;
            this.label115.Text = "～";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(92, 62);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(17, 12);
            this.label114.TabIndex = 78;
            this.label114.Text = "～";
            // 
            // IVup3
            // 
            this.IVup3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVup3.Location = new System.Drawing.Point(112, 89);
            this.IVup3.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup3.Name = "IVup3";
            this.IVup3.Size = new System.Drawing.Size(45, 22);
            this.IVup3.TabIndex = 30;
            this.IVup3.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup3.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVup3.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // IVup1
            // 
            this.IVup1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVup1.Location = new System.Drawing.Point(112, 25);
            this.IVup1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup1.Name = "IVup1";
            this.IVup1.Size = new System.Drawing.Size(45, 22);
            this.IVup1.TabIndex = 26;
            this.IVup1.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVup1.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(92, 126);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(17, 12);
            this.label113.TabIndex = 82;
            this.label113.Text = "～";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(92, 30);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(17, 12);
            this.label112.TabIndex = 76;
            this.label112.Text = "～";
            // 
            // IVup4
            // 
            this.IVup4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVup4.Location = new System.Drawing.Point(112, 121);
            this.IVup4.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup4.Name = "IVup4";
            this.IVup4.Size = new System.Drawing.Size(45, 22);
            this.IVup4.TabIndex = 32;
            this.IVup4.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup4.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVup4.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // IVlow6
            // 
            this.IVlow6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVlow6.Location = new System.Drawing.Point(45, 185);
            this.IVlow6.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVlow6.Name = "IVlow6";
            this.IVlow6.Size = new System.Drawing.Size(45, 22);
            this.IVlow6.TabIndex = 35;
            this.IVlow6.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVlow6.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // IVlow5
            // 
            this.IVlow5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVlow5.Location = new System.Drawing.Point(45, 153);
            this.IVlow5.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVlow5.Name = "IVlow5";
            this.IVlow5.Size = new System.Drawing.Size(45, 22);
            this.IVlow5.TabIndex = 33;
            this.IVlow5.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVlow5.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(92, 158);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(17, 12);
            this.label110.TabIndex = 84;
            this.label110.Text = "～";
            // 
            // IVlow4
            // 
            this.IVlow4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVlow4.Location = new System.Drawing.Point(45, 121);
            this.IVlow4.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVlow4.Name = "IVlow4";
            this.IVlow4.Size = new System.Drawing.Size(45, 22);
            this.IVlow4.TabIndex = 31;
            this.IVlow4.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVlow4.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // IVup5
            // 
            this.IVup5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVup5.Location = new System.Drawing.Point(112, 153);
            this.IVup5.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup5.Name = "IVup5";
            this.IVup5.Size = new System.Drawing.Size(45, 22);
            this.IVup5.TabIndex = 34;
            this.IVup5.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup5.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVup5.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // IVlow3
            // 
            this.IVlow3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVlow3.Location = new System.Drawing.Point(45, 89);
            this.IVlow3.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVlow3.Name = "IVlow3";
            this.IVlow3.Size = new System.Drawing.Size(45, 22);
            this.IVlow3.TabIndex = 29;
            this.IVlow3.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVlow3.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // IVlow2
            // 
            this.IVlow2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVlow2.Location = new System.Drawing.Point(45, 57);
            this.IVlow2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVlow2.Name = "IVlow2";
            this.IVlow2.Size = new System.Drawing.Size(45, 22);
            this.IVlow2.TabIndex = 27;
            this.IVlow2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVlow2.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(92, 190);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(17, 12);
            this.label109.TabIndex = 86;
            this.label109.Text = "～";
            // 
            // IVlow1
            // 
            this.IVlow1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVlow1.Location = new System.Drawing.Point(45, 25);
            this.IVlow1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVlow1.Name = "IVlow1";
            this.IVlow1.Size = new System.Drawing.Size(45, 22);
            this.IVlow1.TabIndex = 25;
            this.IVlow1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVlow1.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_EggS_Search_H
            // 
            this.L_EggS_Search_H.Location = new System.Drawing.Point(1, 26);
            this.L_EggS_Search_H.Name = "L_EggS_Search_H";
            this.L_EggS_Search_H.Size = new System.Drawing.Size(40, 18);
            this.L_EggS_Search_H.TabIndex = 38;
            this.L_EggS_Search_H.Text = "H";
            this.L_EggS_Search_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_EggS_Search_A
            // 
            this.L_EggS_Search_A.Location = new System.Drawing.Point(1, 58);
            this.L_EggS_Search_A.Name = "L_EggS_Search_A";
            this.L_EggS_Search_A.Size = new System.Drawing.Size(40, 18);
            this.L_EggS_Search_A.TabIndex = 40;
            this.L_EggS_Search_A.Text = "A";
            this.L_EggS_Search_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_EggS_Search_B
            // 
            this.L_EggS_Search_B.Location = new System.Drawing.Point(1, 90);
            this.L_EggS_Search_B.Name = "L_EggS_Search_B";
            this.L_EggS_Search_B.Size = new System.Drawing.Size(40, 18);
            this.L_EggS_Search_B.TabIndex = 42;
            this.L_EggS_Search_B.Text = "B";
            this.L_EggS_Search_B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_EggS_Search_C
            // 
            this.L_EggS_Search_C.Location = new System.Drawing.Point(1, 122);
            this.L_EggS_Search_C.Name = "L_EggS_Search_C";
            this.L_EggS_Search_C.Size = new System.Drawing.Size(40, 18);
            this.L_EggS_Search_C.TabIndex = 44;
            this.L_EggS_Search_C.Text = "C";
            this.L_EggS_Search_C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_EggS_Search_D
            // 
            this.L_EggS_Search_D.Location = new System.Drawing.Point(1, 154);
            this.L_EggS_Search_D.Name = "L_EggS_Search_D";
            this.L_EggS_Search_D.Size = new System.Drawing.Size(40, 18);
            this.L_EggS_Search_D.TabIndex = 46;
            this.L_EggS_Search_D.Text = "D";
            this.L_EggS_Search_D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_EggS_Search_S
            // 
            this.L_EggS_Search_S.Location = new System.Drawing.Point(1, 186);
            this.L_EggS_Search_S.Name = "L_EggS_Search_S";
            this.L_EggS_Search_S.Size = new System.Drawing.Size(40, 18);
            this.L_EggS_Search_S.TabIndex = 48;
            this.L_EggS_Search_S.Text = "S";
            this.L_EggS_Search_S.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mezapaType
            // 
            this.mezapaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mezapaType.FormattingEnabled = true;
            this.mezapaType.Location = new System.Drawing.Point(222, 121);
            this.mezapaType.Name = "mezapaType";
            this.mezapaType.Size = new System.Drawing.Size(80, 20);
            this.mezapaType.TabIndex = 39;
            // 
            // L_EggS_Search_HiddenPower
            // 
            this.L_EggS_Search_HiddenPower.Location = new System.Drawing.Point(163, 122);
            this.L_EggS_Search_HiddenPower.Name = "L_EggS_Search_HiddenPower";
            this.L_EggS_Search_HiddenPower.Size = new System.Drawing.Size(57, 18);
            this.L_EggS_Search_HiddenPower.TabIndex = 117;
            this.L_EggS_Search_HiddenPower.Text = "めざパ";
            this.L_EggS_Search_HiddenPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_EggS_Search_Ability
            // 
            this.L_EggS_Search_Ability.Location = new System.Drawing.Point(163, 58);
            this.L_EggS_Search_Ability.Name = "L_EggS_Search_Ability";
            this.L_EggS_Search_Ability.Size = new System.Drawing.Size(57, 18);
            this.L_EggS_Search_Ability.TabIndex = 116;
            this.L_EggS_Search_Ability.Text = "特性";
            this.L_EggS_Search_Ability.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ability
            // 
            this.ability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ability.FormattingEnabled = true;
            this.ability.Items.AddRange(new object[] {
            "指定なし",
            "1",
            "2",
            "夢"});
            this.ability.Location = new System.Drawing.Point(222, 57);
            this.ability.Name = "ability";
            this.ability.Size = new System.Drawing.Size(80, 20);
            this.ability.TabIndex = 37;
            // 
            // L_EggS_Search_Gender
            // 
            this.L_EggS_Search_Gender.Location = new System.Drawing.Point(163, 90);
            this.L_EggS_Search_Gender.Name = "L_EggS_Search_Gender";
            this.L_EggS_Search_Gender.Size = new System.Drawing.Size(57, 18);
            this.L_EggS_Search_Gender.TabIndex = 120;
            this.L_EggS_Search_Gender.Text = "性別";
            this.L_EggS_Search_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Gender
            // 
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "指定なし",
            "♂",
            "♀",
            "-"});
            this.Gender.Location = new System.Drawing.Point(222, 89);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(80, 20);
            this.Gender.TabIndex = 38;
            // 
            // GB_EggS_Filters
            // 
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_Nature);
            this.GB_EggS_Filters.Controls.Add(this.nature);
            this.GB_EggS_Filters.Controls.Add(this.CB_EggS_Search_DisableFilters);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_Ball);
            this.GB_EggS_Filters.Controls.Add(this.ball);
            this.GB_EggS_Filters.Controls.Add(this.Gender);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_Gender);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_Ability);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_HiddenPower);
            this.GB_EggS_Filters.Controls.Add(this.mezapaType);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_S);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_D);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_C);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_B);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_A);
            this.GB_EggS_Filters.Controls.Add(this.L_EggS_Search_H);
            this.GB_EggS_Filters.Controls.Add(this.IVup6);
            this.GB_EggS_Filters.Controls.Add(this.IVlow1);
            this.GB_EggS_Filters.Controls.Add(this.label109);
            this.GB_EggS_Filters.Controls.Add(this.IVlow2);
            this.GB_EggS_Filters.Controls.Add(this.IVlow3);
            this.GB_EggS_Filters.Controls.Add(this.IVup5);
            this.GB_EggS_Filters.Controls.Add(this.IVlow4);
            this.GB_EggS_Filters.Controls.Add(this.label110);
            this.GB_EggS_Filters.Controls.Add(this.IVlow5);
            this.GB_EggS_Filters.Controls.Add(this.IVlow6);
            this.GB_EggS_Filters.Controls.Add(this.IVup4);
            this.GB_EggS_Filters.Controls.Add(this.label112);
            this.GB_EggS_Filters.Controls.Add(this.label113);
            this.GB_EggS_Filters.Controls.Add(this.IVup1);
            this.GB_EggS_Filters.Controls.Add(this.IVup3);
            this.GB_EggS_Filters.Controls.Add(this.label114);
            this.GB_EggS_Filters.Controls.Add(this.label115);
            this.GB_EggS_Filters.Controls.Add(this.IVup2);
            this.GB_EggS_Filters.Controls.Add(this.ability);
            this.GB_EggS_Filters.Location = new System.Drawing.Point(381, 6);
            this.GB_EggS_Filters.Name = "GB_EggS_Filters";
            this.GB_EggS_Filters.Size = new System.Drawing.Size(310, 226);
            this.GB_EggS_Filters.TabIndex = 20;
            this.GB_EggS_Filters.TabStop = false;
            this.GB_EggS_Filters.Text = "フィルター";
            // 
            // L_EggS_Search_Nature
            // 
            this.L_EggS_Search_Nature.Location = new System.Drawing.Point(163, 26);
            this.L_EggS_Search_Nature.Name = "L_EggS_Search_Nature";
            this.L_EggS_Search_Nature.Size = new System.Drawing.Size(57, 18);
            this.L_EggS_Search_Nature.TabIndex = 188;
            this.L_EggS_Search_Nature.Text = "性格";
            this.L_EggS_Search_Nature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nature
            // 
            this.nature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nature.FormattingEnabled = true;
            this.nature.Location = new System.Drawing.Point(222, 25);
            this.nature.Name = "nature";
            this.nature.Size = new System.Drawing.Size(80, 20);
            this.nature.TabIndex = 187;
            // 
            // CB_EggS_Search_DisableFilters
            // 
            this.CB_EggS_Search_DisableFilters.AutoSize = true;
            this.CB_EggS_Search_DisableFilters.Location = new System.Drawing.Point(194, 189);
            this.CB_EggS_Search_DisableFilters.Name = "CB_EggS_Search_DisableFilters";
            this.CB_EggS_Search_DisableFilters.Size = new System.Drawing.Size(100, 16);
            this.CB_EggS_Search_DisableFilters.TabIndex = 186;
            this.CB_EggS_Search_DisableFilters.Text = "絞り込みを無効";
            this.CB_EggS_Search_DisableFilters.UseVisualStyleBackColor = true;
            // 
            // L_EggS_Search_Ball
            // 
            this.L_EggS_Search_Ball.Location = new System.Drawing.Point(163, 154);
            this.L_EggS_Search_Ball.Name = "L_EggS_Search_Ball";
            this.L_EggS_Search_Ball.Size = new System.Drawing.Size(57, 18);
            this.L_EggS_Search_Ball.TabIndex = 122;
            this.L_EggS_Search_Ball.Text = "ボール";
            this.L_EggS_Search_Ball.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ball
            // 
            this.ball.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ball.FormattingEnabled = true;
            this.ball.Items.AddRange(new object[] {
            "指定なし",
            "先親",
            "後親"});
            this.ball.Location = new System.Drawing.Point(222, 153);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(80, 20);
            this.ball.TabIndex = 40;
            // 
            // IVup6
            // 
            this.IVup6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVup6.Location = new System.Drawing.Point(112, 185);
            this.IVup6.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup6.Name = "IVup6";
            this.IVup6.Size = new System.Drawing.Size(45, 22);
            this.IVup6.TabIndex = 36;
            this.IVup6.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.IVup6.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.IVup6.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // B_EggS_Search
            // 
            this.B_EggS_Search.Location = new System.Drawing.Point(926, 209);
            this.B_EggS_Search.Name = "B_EggS_Search";
            this.B_EggS_Search.Size = new System.Drawing.Size(75, 23);
            this.B_EggS_Search.TabIndex = 176;
            this.B_EggS_Search.Text = "計算";
            this.B_EggS_Search.UseVisualStyleBackColor = true;
            this.B_EggS_Search.Click += new System.EventHandler(this.EggSearch_Click);
            // 
            // CB_EggS_ShinyCharm
            // 
            this.CB_EggS_ShinyCharm.AutoSize = true;
            this.CB_EggS_ShinyCharm.Location = new System.Drawing.Point(22, 52);
            this.CB_EggS_ShinyCharm.Name = "CB_EggS_ShinyCharm";
            this.CB_EggS_ShinyCharm.Size = new System.Drawing.Size(75, 16);
            this.CB_EggS_ShinyCharm.TabIndex = 174;
            this.CB_EggS_ShinyCharm.Text = "光るお守り";
            this.CB_EggS_ShinyCharm.UseVisualStyleBackColor = true;
            this.CB_EggS_ShinyCharm.Click += new System.EventHandler(this.omamori_CheckedChanged);
            // 
            // GB_EggS_SearchSettings
            // 
            this.GB_EggS_SearchSettings.Controls.Add(this.TSV);
            this.GB_EggS_SearchSettings.Controls.Add(this.CB_EggS_OtherTSV);
            this.GB_EggS_SearchSettings.Controls.Add(this.CB_EggS_TSV_Shiny);
            this.GB_EggS_SearchSettings.Controls.Add(this.label20);
            this.GB_EggS_SearchSettings.Controls.Add(this.CB_EggS_Shiny);
            this.GB_EggS_SearchSettings.Controls.Add(this.CB_EggS_International);
            this.GB_EggS_SearchSettings.Controls.Add(this.CB_EggS_ShinyCharm);
            this.GB_EggS_SearchSettings.Location = new System.Drawing.Point(926, 6);
            this.GB_EggS_SearchSettings.Name = "GB_EggS_SearchSettings";
            this.GB_EggS_SearchSettings.Size = new System.Drawing.Size(182, 197);
            this.GB_EggS_SearchSettings.TabIndex = 177;
            this.GB_EggS_SearchSettings.TabStop = false;
            this.GB_EggS_SearchSettings.Text = "その他";
            // 
            // TSV
            // 
            this.TSV.Font = new System.Drawing.Font("Consolas", 9F);
            this.TSV.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TSV.Location = new System.Drawing.Point(53, 129);
            this.TSV.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.TSV.Name = "TSV";
            this.TSV.Size = new System.Drawing.Size(58, 22);
            this.TSV.TabIndex = 186;
            // 
            // CB_EggS_OtherTSV
            // 
            this.CB_EggS_OtherTSV.AutoSize = true;
            this.CB_EggS_OtherTSV.Location = new System.Drawing.Point(22, 168);
            this.CB_EggS_OtherTSV.Name = "CB_EggS_OtherTSV";
            this.CB_EggS_OtherTSV.Size = new System.Drawing.Size(133, 16);
            this.CB_EggS_OtherTSV.TabIndex = 185;
            this.CB_EggS_OtherTSV.Text = "他TSVで色違いを探す";
            this.CB_EggS_OtherTSV.UseVisualStyleBackColor = true;
            // 
            // CB_EggS_TSV_Shiny
            // 
            this.CB_EggS_TSV_Shiny.AutoSize = true;
            this.CB_EggS_TSV_Shiny.Checked = true;
            this.CB_EggS_TSV_Shiny.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_EggS_TSV_Shiny.Location = new System.Drawing.Point(22, 105);
            this.CB_EggS_TSV_Shiny.Name = "CB_EggS_TSV_Shiny";
            this.CB_EggS_TSV_Shiny.Size = new System.Drawing.Size(149, 16);
            this.CB_EggS_TSV_Shiny.TabIndex = 184;
            this.CB_EggS_TSV_Shiny.Text = "TSVを考慮した計算をする";
            this.CB_EggS_TSV_Shiny.UseVisualStyleBackColor = true;
            this.CB_EggS_TSV_Shiny.Click += new System.EventHandler(this.ConsiderTSVcheck);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(19, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 14);
            this.label20.TabIndex = 180;
            this.label20.Text = "TSV";
            // 
            // CB_EggS_Shiny
            // 
            this.CB_EggS_Shiny.AutoSize = true;
            this.CB_EggS_Shiny.Location = new System.Drawing.Point(22, 77);
            this.CB_EggS_Shiny.Name = "CB_EggS_Shiny";
            this.CB_EggS_Shiny.Size = new System.Drawing.Size(103, 16);
            this.CB_EggS_Shiny.TabIndex = 178;
            this.CB_EggS_Shiny.Text = "色違いのみ出力";
            this.CB_EggS_Shiny.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Tab_EggSearch);
            this.tabControl1.Controls.Add(this.Tab_EggList);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_EggSearch
            // 
            this.Tab_EggSearch.Controls.Add(this.GB_EggS_Parents_Info);
            this.Tab_EggSearch.Controls.Add(this.GB_EggS_Filters);
            this.Tab_EggSearch.Controls.Add(this.B_EggS_Search);
            this.Tab_EggSearch.Controls.Add(this.GB_EggS_SearchSettings);
            this.Tab_EggSearch.Controls.Add(this.EggS_dataGridView);
            this.Tab_EggSearch.Controls.Add(this.GB_EggS_RNGInfo);
            this.Tab_EggSearch.Location = new System.Drawing.Point(4, 22);
            this.Tab_EggSearch.Name = "Tab_EggSearch";
            this.Tab_EggSearch.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_EggSearch.Size = new System.Drawing.Size(1116, 500);
            this.Tab_EggSearch.TabIndex = 0;
            this.Tab_EggSearch.Text = "個体検索";
            this.Tab_EggSearch.UseVisualStyleBackColor = true;
            // 
            // Tab_EggList
            // 
            this.Tab_EggList.Controls.Add(this.List_search);
            this.Tab_EggList.Controls.Add(this.L_dataGridView);
            this.Tab_EggList.Controls.Add(this.L_RNGInfo);
            this.Tab_EggList.Location = new System.Drawing.Point(4, 22);
            this.Tab_EggList.Name = "Tab_EggList";
            this.Tab_EggList.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_EggList.Size = new System.Drawing.Size(1116, 500);
            this.Tab_EggList.TabIndex = 1;
            this.Tab_EggList.Text = "連続孵化リスト";
            this.Tab_EggList.UseVisualStyleBackColor = true;
            // 
            // List_search
            // 
            this.List_search.Location = new System.Drawing.Point(154, 335);
            this.List_search.Name = "List_search";
            this.List_search.Size = new System.Drawing.Size(75, 23);
            this.List_search.TabIndex = 182;
            this.List_search.Text = "計算";
            this.List_search.UseVisualStyleBackColor = true;
            this.List_search.Click += new System.EventHandler(this.EggList_Search_Click);
            // 
            // L_dataGridView
            // 
            this.L_dataGridView.AllowUserToAddRows = false;
            this.L_dataGridView.AllowUserToResizeColumns = false;
            this.L_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.L_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvE_frame,
            this.dgvE_used,
            this.dgvE_seed,
            this.dgvE_H,
            this.dgvE_A,
            this.dgvE_B,
            this.dgvE_C,
            this.dgvE_D,
            this.dgvE_S,
            this.dgvE_gender,
            this.dgvE_ability,
            this.dgvE_nature,
            this.dgvE_pid,
            this.dgvE_psv,
            this.dgvE_ec,
            this.dgvE_rand});
            this.L_dataGridView.ContextMenuStrip = this.contextMenuStrip2;
            this.L_dataGridView.Location = new System.Drawing.Point(235, 6);
            this.L_dataGridView.Name = "L_dataGridView";
            this.L_dataGridView.RowTemplate.Height = 21;
            this.L_dataGridView.Size = new System.Drawing.Size(877, 498);
            this.L_dataGridView.TabIndex = 0;
            // 
            // dgvE_frame
            // 
            this.dgvE_frame.HeaderText = "受取";
            this.dgvE_frame.Name = "dgvE_frame";
            this.dgvE_frame.Width = 54;
            // 
            // dgvE_used
            // 
            this.dgvE_used.HeaderText = "消費";
            this.dgvE_used.Name = "dgvE_used";
            this.dgvE_used.Width = 54;
            // 
            // dgvE_seed
            // 
            this.dgvE_seed.HeaderText = "Seed";
            this.dgvE_seed.Name = "dgvE_seed";
            this.dgvE_seed.Width = 270;
            // 
            // dgvE_H
            // 
            this.dgvE_H.HeaderText = "H";
            this.dgvE_H.Name = "dgvE_H";
            this.dgvE_H.Width = 27;
            // 
            // dgvE_A
            // 
            this.dgvE_A.HeaderText = "A";
            this.dgvE_A.Name = "dgvE_A";
            this.dgvE_A.Width = 27;
            // 
            // dgvE_B
            // 
            this.dgvE_B.HeaderText = "B";
            this.dgvE_B.Name = "dgvE_B";
            this.dgvE_B.Width = 27;
            // 
            // dgvE_C
            // 
            this.dgvE_C.HeaderText = "C";
            this.dgvE_C.Name = "dgvE_C";
            this.dgvE_C.Width = 27;
            // 
            // dgvE_D
            // 
            this.dgvE_D.HeaderText = "D";
            this.dgvE_D.Name = "dgvE_D";
            this.dgvE_D.Width = 27;
            // 
            // dgvE_S
            // 
            this.dgvE_S.HeaderText = "S";
            this.dgvE_S.Name = "dgvE_S";
            this.dgvE_S.Width = 27;
            // 
            // dgvE_gender
            // 
            this.dgvE_gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvE_gender.HeaderText = "性別";
            this.dgvE_gender.Name = "dgvE_gender";
            this.dgvE_gender.Width = 54;
            // 
            // dgvE_ability
            // 
            this.dgvE_ability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvE_ability.HeaderText = "特性";
            this.dgvE_ability.Name = "dgvE_ability";
            this.dgvE_ability.Width = 54;
            // 
            // dgvE_nature
            // 
            this.dgvE_nature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvE_nature.HeaderText = "性格";
            this.dgvE_nature.Name = "dgvE_nature";
            this.dgvE_nature.Width = 54;
            // 
            // dgvE_pid
            // 
            this.dgvE_pid.HeaderText = "性格値";
            this.dgvE_pid.Name = "dgvE_pid";
            this.dgvE_pid.Width = 66;
            // 
            // dgvE_psv
            // 
            this.dgvE_psv.HeaderText = "SV";
            this.dgvE_psv.Name = "dgvE_psv";
            this.dgvE_psv.Width = 54;
            // 
            // dgvE_ec
            // 
            this.dgvE_ec.HeaderText = "暗号化定数";
            this.dgvE_ec.Name = "dgvE_ec";
            this.dgvE_ec.Width = 90;
            // 
            // dgvE_rand
            // 
            this.dgvE_rand.HeaderText = "乱数列";
            this.dgvE_rand.Name = "dgvE_rand";
            this.dgvE_rand.Width = 90;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu2Copy,
            this.mnu2SelectAll});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(120, 48);
            // 
            // mnu2Copy
            // 
            this.mnu2Copy.Name = "mnu2Copy";
            this.mnu2Copy.Size = new System.Drawing.Size(119, 22);
            this.mnu2Copy.Text = "コピー";
            this.mnu2Copy.Click += new System.EventHandler(this.L_copyToolStripMenuItem_Click);
            // 
            // mnu2SelectAll
            // 
            this.mnu2SelectAll.Name = "mnu2SelectAll";
            this.mnu2SelectAll.Size = new System.Drawing.Size(119, 22);
            this.mnu2SelectAll.Text = "全て選択";
            this.mnu2SelectAll.Click += new System.EventHandler(this.L_SelectAllToolStripMenuItem_Click);
            // 
            // L_RNGInfo
            // 
            this.L_RNGInfo.Controls.Add(this.Repeat_times);
            this.L_RNGInfo.Controls.Add(this.Target_frame);
            this.L_RNGInfo.Controls.Add(this.L_targetframe);
            this.L_RNGInfo.Controls.Add(this.L_status3a);
            this.L_RNGInfo.Controls.Add(this.L_status2a);
            this.L_RNGInfo.Controls.Add(this.L_status1a);
            this.L_RNGInfo.Controls.Add(this.L_status0a);
            this.L_RNGInfo.Controls.Add(this.n_min);
            this.L_RNGInfo.Controls.Add(this.n_max);
            this.L_RNGInfo.Controls.Add(this.L_TSV_shiny);
            this.L_RNGInfo.Controls.Add(this.label63);
            this.L_RNGInfo.Controls.Add(this.label64);
            this.L_RNGInfo.Controls.Add(this.label65);
            this.L_RNGInfo.Controls.Add(this.label66);
            this.L_RNGInfo.Controls.Add(this.label67);
            this.L_RNGInfo.Controls.Add(this.label68);
            this.L_RNGInfo.Controls.Add(this.label69);
            this.L_RNGInfo.Controls.Add(this.label70);
            this.L_RNGInfo.Controls.Add(this.L_eggrange);
            this.L_RNGInfo.Controls.Add(this.label72);
            this.L_RNGInfo.Location = new System.Drawing.Point(6, 6);
            this.L_RNGInfo.Name = "L_RNGInfo";
            this.L_RNGInfo.Size = new System.Drawing.Size(223, 323);
            this.L_RNGInfo.TabIndex = 180;
            this.L_RNGInfo.TabStop = false;
            this.L_RNGInfo.Text = "検索範囲";
            // 
            // Repeat_times
            // 
            this.Repeat_times.AutoSize = true;
            this.Repeat_times.Location = new System.Drawing.Point(16, 287);
            this.Repeat_times.Name = "Repeat_times";
            this.Repeat_times.Size = new System.Drawing.Size(9, 12);
            this.Repeat_times.TabIndex = 84;
            this.Repeat_times.Text = " ";
            // 
            // Target_frame
            // 
            this.Target_frame.Font = new System.Drawing.Font("Consolas", 9F);
            this.Target_frame.Location = new System.Drawing.Point(90, 247);
            this.Target_frame.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Target_frame.Name = "Target_frame";
            this.Target_frame.Size = new System.Drawing.Size(80, 22);
            this.Target_frame.TabIndex = 82;
            // 
            // L_targetframe
            // 
            this.L_targetframe.AutoSize = true;
            this.L_targetframe.Location = new System.Drawing.Point(16, 250);
            this.L_targetframe.Name = "L_targetframe";
            this.L_targetframe.Size = new System.Drawing.Size(53, 12);
            this.L_targetframe.TabIndex = 83;
            this.L_targetframe.Text = "目標消費";
            // 
            // L_status3a
            // 
            this.L_status3a.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_status3a.Hexadecimal = true;
            this.L_status3a.Location = new System.Drawing.Point(118, 24);
            this.L_status3a.Name = "L_status3a";
            this.L_status3a.Size = new System.Drawing.Size(80, 22);
            this.L_status3a.TabIndex = 1;
            this.L_status3a.Value = new decimal(new int[] {
            305419896,
            0,
            0,
            0});
            this.L_status3a.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.L_status3a.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_status2a
            // 
            this.L_status2a.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_status2a.Hexadecimal = true;
            this.L_status2a.Location = new System.Drawing.Point(118, 52);
            this.L_status2a.Name = "L_status2a";
            this.L_status2a.Size = new System.Drawing.Size(80, 22);
            this.L_status2a.TabIndex = 2;
            this.L_status2a.Value = new decimal(new int[] {
            -559023410,
            0,
            0,
            0});
            this.L_status2a.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.L_status2a.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_status1a
            // 
            this.L_status1a.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_status1a.Hexadecimal = true;
            this.L_status1a.Location = new System.Drawing.Point(118, 80);
            this.L_status1a.Name = "L_status1a";
            this.L_status1a.Size = new System.Drawing.Size(80, 22);
            this.L_status1a.TabIndex = 3;
            this.L_status1a.Value = new decimal(new int[] {
            -559038737,
            0,
            0,
            0});
            this.L_status1a.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.L_status1a.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_status0a
            // 
            this.L_status0a.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_status0a.Hexadecimal = true;
            this.L_status0a.Location = new System.Drawing.Point(118, 108);
            this.L_status0a.Name = "L_status0a";
            this.L_status0a.Size = new System.Drawing.Size(80, 22);
            this.L_status0a.TabIndex = 4;
            this.L_status0a.Value = new decimal(new int[] {
            -1091568946,
            0,
            0,
            0});
            this.L_status0a.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.L_status0a.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // n_min
            // 
            this.n_min.Font = new System.Drawing.Font("Consolas", 9F);
            this.n_min.Location = new System.Drawing.Point(20, 174);
            this.n_min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.n_min.Name = "n_min";
            this.n_min.Size = new System.Drawing.Size(80, 22);
            this.n_min.TabIndex = 6;
            this.n_min.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.n_min.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // n_max
            // 
            this.n_max.Font = new System.Drawing.Font("Consolas", 9F);
            this.n_max.Location = new System.Drawing.Point(130, 174);
            this.n_max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.n_max.Name = "n_max";
            this.n_max.Size = new System.Drawing.Size(80, 22);
            this.n_max.TabIndex = 7;
            this.n_max.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.n_max.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.n_max.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // L_TSV_shiny
            // 
            this.L_TSV_shiny.AutoSize = true;
            this.L_TSV_shiny.Checked = true;
            this.L_TSV_shiny.CheckState = System.Windows.Forms.CheckState.Checked;
            this.L_TSV_shiny.Location = new System.Drawing.Point(18, 210);
            this.L_TSV_shiny.Name = "L_TSV_shiny";
            this.L_TSV_shiny.Size = new System.Drawing.Size(149, 16);
            this.L_TSV_shiny.TabIndex = 8;
            this.L_TSV_shiny.Text = "TSVを考慮した計算をする";
            this.L_TSV_shiny.UseVisualStyleBackColor = true;
            this.L_TSV_shiny.Click += new System.EventHandler(this.ConsiderTSVcheck);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Consolas", 9F);
            this.label63.Location = new System.Drawing.Point(15, 110);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(70, 14);
            this.label63.TabIndex = 77;
            this.label63.Text = "status[0]";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(91, 110);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(21, 14);
            this.label64.TabIndex = 76;
            this.label64.Text = "0x";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Consolas", 9F);
            this.label65.Location = new System.Drawing.Point(15, 82);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(70, 14);
            this.label65.TabIndex = 74;
            this.label65.Text = "status[1]";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(91, 82);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(21, 14);
            this.label66.TabIndex = 73;
            this.label66.Text = "0x";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Consolas", 9F);
            this.label67.Location = new System.Drawing.Point(15, 54);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(70, 14);
            this.label67.TabIndex = 71;
            this.label67.Text = "status[2]";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(91, 54);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(21, 14);
            this.label68.TabIndex = 70;
            this.label68.Text = "0x";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Consolas", 9F);
            this.label69.Location = new System.Drawing.Point(15, 26);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(70, 14);
            this.label69.TabIndex = 68;
            this.label69.Text = "status[3]";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(91, 26);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(21, 14);
            this.label70.TabIndex = 67;
            this.label70.Text = "0x";
            // 
            // L_eggrange
            // 
            this.L_eggrange.AutoSize = true;
            this.L_eggrange.Location = new System.Drawing.Point(16, 152);
            this.L_eggrange.Name = "L_eggrange";
            this.L_eggrange.Size = new System.Drawing.Size(71, 12);
            this.L_eggrange.TabIndex = 64;
            this.L_eggrange.Text = "受け取り回数";
            // 
            // label72
            // 
            this.label72.Location = new System.Drawing.Point(106, 180);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(18, 16);
            this.label72.TabIndex = 61;
            this.label72.Text = "～";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Options});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 24);
            this.menuStrip1.TabIndex = 181;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(39, 20);
            this.Menu_File.Text = "File";
            // 
            // Menu_Exit
            // 
            this.Menu_Exit.Name = "Menu_Exit";
            this.Menu_Exit.Size = new System.Drawing.Size(96, 22);
            this.Menu_Exit.Text = "Exit";
            this.Menu_Exit.Click += new System.EventHandler(this.mainMenuExit);
            // 
            // Menu_Options
            // 
            this.Menu_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Language,
            this.Menu_SaveConfig,
            this.Menu_TSV,
            this.Menu_ParentsList});
            this.Menu_Options.Name = "Menu_Options";
            this.Menu_Options.Size = new System.Drawing.Size(63, 20);
            this.Menu_Options.Text = "Options";
            // 
            // Menu_Language
            // 
            this.Menu_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CB_MainLanguage});
            this.Menu_Language.Name = "Menu_Language";
            this.Menu_Language.Size = new System.Drawing.Size(143, 22);
            this.Menu_Language.Text = "Language";
            // 
            // CB_MainLanguage
            // 
            this.CB_MainLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MainLanguage.Name = "CB_MainLanguage";
            this.CB_MainLanguage.Size = new System.Drawing.Size(121, 23);
            this.CB_MainLanguage.SelectedIndexChanged += new System.EventHandler(this.changeLanguage);
            // 
            // Menu_SaveConfig
            // 
            this.Menu_SaveConfig.Name = "Menu_SaveConfig";
            this.Menu_SaveConfig.Size = new System.Drawing.Size(143, 22);
            this.Menu_SaveConfig.Text = "Save Config";
            this.Menu_SaveConfig.Click += new System.EventHandler(this.B_SaveConfig_Click);
            // 
            // Menu_TSV
            // 
            this.Menu_TSV.Name = "Menu_TSV";
            this.Menu_TSV.Size = new System.Drawing.Size(143, 22);
            this.Menu_TSV.Text = "TSV List";
            this.Menu_TSV.Click += new System.EventHandler(this.B_TSV_Click);
            // 
            // Menu_ParentsList
            // 
            this.Menu_ParentsList.Name = "Menu_ParentsList";
            this.Menu_ParentsList.Size = new System.Drawing.Size(143, 22);
            this.Menu_ParentsList.Text = "Parents List";
            this.Menu_ParentsList.Click += new System.EventHandler(this.B_Parents_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.Tab_Stationary);
            this.tabControl2.Controls.Add(this.Tab_Egg);
            this.tabControl2.Controls.Add(this.Tab_ID);
            this.tabControl2.Controls.Add(this.other);
            this.tabControl2.Location = new System.Drawing.Point(12, 25);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1144, 564);
            this.tabControl2.TabIndex = 182;
            // 
            // Tab_Stationary
            // 
            this.Tab_Stationary.Controls.Add(this.tabControl3);
            this.Tab_Stationary.Location = new System.Drawing.Point(4, 22);
            this.Tab_Stationary.Name = "Tab_Stationary";
            this.Tab_Stationary.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Stationary.Size = new System.Drawing.Size(1136, 538);
            this.Tab_Stationary.TabIndex = 0;
            this.Tab_Stationary.Text = "固定乱数";
            this.Tab_Stationary.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.Tab_StationarySearch);
            this.tabControl3.Controls.Add(this.Tab_StationaryClock);
            this.tabControl3.Location = new System.Drawing.Point(6, 6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1124, 526);
            this.tabControl3.TabIndex = 179;
            // 
            // Tab_StationarySearch
            // 
            this.Tab_StationarySearch.Controls.Add(this.St_RNGInfo);
            this.Tab_StationarySearch.Controls.Add(this.St_SearchSettings);
            this.Tab_StationarySearch.Controls.Add(this.St_Filters);
            this.Tab_StationarySearch.Controls.Add(this.Stationary_List);
            this.Tab_StationarySearch.Controls.Add(this.St_dataGridView);
            this.Tab_StationarySearch.Controls.Add(this.Stationary_Search);
            this.Tab_StationarySearch.Location = new System.Drawing.Point(4, 22);
            this.Tab_StationarySearch.Name = "Tab_StationarySearch";
            this.Tab_StationarySearch.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_StationarySearch.Size = new System.Drawing.Size(1116, 500);
            this.Tab_StationarySearch.TabIndex = 0;
            this.Tab_StationarySearch.Text = "個体検索";
            this.Tab_StationarySearch.UseVisualStyleBackColor = true;
            // 
            // St_RNGInfo
            // 
            this.St_RNGInfo.Controls.Add(this.St_L_InitialSeed);
            this.St_RNGInfo.Controls.Add(this.label7);
            this.St_RNGInfo.Controls.Add(this.St_UpdateFrame);
            this.St_RNGInfo.Controls.Add(this.St_L_TargetFrame);
            this.St_RNGInfo.Controls.Add(this.label51);
            this.St_RNGInfo.Controls.Add(this.St_Frame);
            this.St_RNGInfo.Controls.Add(this.label39);
            this.St_RNGInfo.Controls.Add(this.St_InitialSeed);
            this.St_RNGInfo.Controls.Add(this.St_min);
            this.St_RNGInfo.Controls.Add(this.St_max);
            this.St_RNGInfo.Controls.Add(this.St_TargetFrame);
            this.St_RNGInfo.Controls.Add(this.St_TargetFrame_Range);
            this.St_RNGInfo.Location = new System.Drawing.Point(6, 6);
            this.St_RNGInfo.Name = "St_RNGInfo";
            this.St_RNGInfo.Size = new System.Drawing.Size(387, 129);
            this.St_RNGInfo.TabIndex = 0;
            this.St_RNGInfo.TabStop = false;
            this.St_RNGInfo.Text = "検索範囲";
            // 
            // St_L_InitialSeed
            // 
            this.St_L_InitialSeed.Font = new System.Drawing.Font("Consolas", 9F);
            this.St_L_InitialSeed.Location = new System.Drawing.Point(0, 29);
            this.St_L_InitialSeed.Name = "St_L_InitialSeed";
            this.St_L_InitialSeed.Size = new System.Drawing.Size(80, 28);
            this.St_L_InitialSeed.TabIndex = 72;
            this.St_L_InitialSeed.Text = "初期seed";
            this.St_L_InitialSeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 14);
            this.label7.TabIndex = 71;
            this.label7.Text = "0x";
            // 
            // St_UpdateFrame
            // 
            this.St_UpdateFrame.Location = new System.Drawing.Point(299, 92);
            this.St_UpdateFrame.Name = "St_UpdateFrame";
            this.St_UpdateFrame.Size = new System.Drawing.Size(75, 23);
            this.St_UpdateFrame.TabIndex = 13;
            this.St_UpdateFrame.Text = "上書き";
            this.St_UpdateFrame.UseVisualStyleBackColor = true;
            this.St_UpdateFrame.Click += new System.EventHandler(this.St_UpdateFrame_Click);
            // 
            // St_L_TargetFrame
            // 
            this.St_L_TargetFrame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_L_TargetFrame.Location = new System.Drawing.Point(6, 96);
            this.St_L_TargetFrame.Name = "St_L_TargetFrame";
            this.St_L_TargetFrame.Size = new System.Drawing.Size(100, 14);
            this.St_L_TargetFrame.TabIndex = 68;
            this.St_L_TargetFrame.Text = "目標Frame";
            this.St_L_TargetFrame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(198, 97);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(18, 16);
            this.label51.TabIndex = 65;
            this.label51.Text = "±";
            // 
            // St_Frame
            // 
            this.St_Frame.AutoSize = true;
            this.St_Frame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Frame.Location = new System.Drawing.Point(58, 62);
            this.St_Frame.Name = "St_Frame";
            this.St_Frame.Size = new System.Drawing.Size(42, 14);
            this.St_Frame.TabIndex = 64;
            this.St_Frame.Text = "Frame";
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(198, 65);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(18, 16);
            this.label39.TabIndex = 61;
            this.label39.Text = "～";
            // 
            // St_InitialSeed
            // 
            this.St_InitialSeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_InitialSeed.Hexadecimal = true;
            this.St_InitialSeed.Location = new System.Drawing.Point(112, 27);
            this.St_InitialSeed.Name = "St_InitialSeed";
            this.St_InitialSeed.Size = new System.Drawing.Size(80, 22);
            this.St_InitialSeed.TabIndex = 1;
            this.St_InitialSeed.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_InitialSeed.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_min
            // 
            this.St_min.Font = new System.Drawing.Font("Consolas", 9F);
            this.St_min.Location = new System.Drawing.Point(112, 60);
            this.St_min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.St_min.Name = "St_min";
            this.St_min.Size = new System.Drawing.Size(80, 22);
            this.St_min.TabIndex = 2;
            this.St_min.Value = new decimal(new int[] {
            417,
            0,
            0,
            0});
            this.St_min.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_min.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_max
            // 
            this.St_max.Font = new System.Drawing.Font("Consolas", 9F);
            this.St_max.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.St_max.Location = new System.Drawing.Point(222, 60);
            this.St_max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.St_max.Name = "St_max";
            this.St_max.Size = new System.Drawing.Size(80, 22);
            this.St_max.TabIndex = 3;
            this.St_max.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.St_max.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_max.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_TargetFrame
            // 
            this.St_TargetFrame.Font = new System.Drawing.Font("Consolas", 9F);
            this.St_TargetFrame.Location = new System.Drawing.Point(112, 92);
            this.St_TargetFrame.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.St_TargetFrame.Name = "St_TargetFrame";
            this.St_TargetFrame.Size = new System.Drawing.Size(80, 22);
            this.St_TargetFrame.TabIndex = 4;
            this.St_TargetFrame.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.St_TargetFrame.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_TargetFrame.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_TargetFrame_Range
            // 
            this.St_TargetFrame_Range.Font = new System.Drawing.Font("Consolas", 9F);
            this.St_TargetFrame_Range.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.St_TargetFrame_Range.Location = new System.Drawing.Point(222, 92);
            this.St_TargetFrame_Range.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.St_TargetFrame_Range.Name = "St_TargetFrame_Range";
            this.St_TargetFrame_Range.Size = new System.Drawing.Size(62, 22);
            this.St_TargetFrame_Range.TabIndex = 5;
            this.St_TargetFrame_Range.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.St_TargetFrame_Range.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_TargetFrame_Range.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_SearchSettings
            // 
            this.St_SearchSettings.Controls.Add(this.Valid_Blink);
            this.St_SearchSettings.Controls.Add(this.St_SynchroOnly);
            this.St_SearchSettings.Controls.Add(this.AlwaysSynchro);
            this.St_SearchSettings.Controls.Add(this.St_TSV);
            this.St_SearchSettings.Controls.Add(this.St_shiny);
            this.St_SearchSettings.Controls.Add(this.label8);
            this.St_SearchSettings.Location = new System.Drawing.Point(6, 406);
            this.St_SearchSettings.Name = "St_SearchSettings";
            this.St_SearchSettings.Size = new System.Drawing.Size(306, 88);
            this.St_SearchSettings.TabIndex = 2;
            this.St_SearchSettings.TabStop = false;
            this.St_SearchSettings.Text = "その他";
            // 
            // Valid_Blink
            // 
            this.Valid_Blink.AutoSize = true;
            this.Valid_Blink.Location = new System.Drawing.Point(21, 65);
            this.Valid_Blink.Name = "Valid_Blink";
            this.Valid_Blink.Size = new System.Drawing.Size(162, 16);
            this.Valid_Blink.TabIndex = 188;
            this.Valid_Blink.Text = "まばたき契機を考慮(シンクロ)";
            this.Valid_Blink.UseVisualStyleBackColor = true;
            // 
            // St_SynchroOnly
            // 
            this.St_SynchroOnly.AutoSize = true;
            this.St_SynchroOnly.Location = new System.Drawing.Point(21, 45);
            this.St_SynchroOnly.Name = "St_SynchroOnly";
            this.St_SynchroOnly.Size = new System.Drawing.Size(129, 16);
            this.St_SynchroOnly.TabIndex = 51;
            this.St_SynchroOnly.Text = "シンクロ個体のみ出力";
            this.St_SynchroOnly.UseVisualStyleBackColor = true;
            // 
            // AlwaysSynchro
            // 
            this.AlwaysSynchro.AutoSize = true;
            this.AlwaysSynchro.Location = new System.Drawing.Point(21, 25);
            this.AlwaysSynchro.Name = "AlwaysSynchro";
            this.AlwaysSynchro.Size = new System.Drawing.Size(75, 16);
            this.AlwaysSynchro.TabIndex = 50;
            this.AlwaysSynchro.Text = "タイプ・ヌル";
            this.AlwaysSynchro.UseVisualStyleBackColor = true;
            // 
            // St_TSV
            // 
            this.St_TSV.Font = new System.Drawing.Font("Consolas", 9F);
            this.St_TSV.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.St_TSV.Location = new System.Drawing.Point(231, 21);
            this.St_TSV.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.St_TSV.Name = "St_TSV";
            this.St_TSV.Size = new System.Drawing.Size(58, 22);
            this.St_TSV.TabIndex = 52;
            this.St_TSV.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_TSV.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_shiny
            // 
            this.St_shiny.AutoSize = true;
            this.St_shiny.Location = new System.Drawing.Point(197, 49);
            this.St_shiny.Name = "St_shiny";
            this.St_shiny.Size = new System.Drawing.Size(103, 16);
            this.St_shiny.TabIndex = 53;
            this.St_shiny.Text = "色違いのみ出力";
            this.St_shiny.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 14);
            this.label8.TabIndex = 187;
            this.label8.Text = "TSV";
            // 
            // St_Filters
            // 
            this.St_Filters.Controls.Add(this.St_stats6);
            this.St_Filters.Controls.Add(this.St_stats3);
            this.St_Filters.Controls.Add(this.St_stats4);
            this.St_Filters.Controls.Add(this.St_stats5);
            this.St_Filters.Controls.Add(this.St_stats2);
            this.St_Filters.Controls.Add(this.St_stats1);
            this.St_Filters.Controls.Add(this.synchro_nature);
            this.St_Filters.Controls.Add(this.St_Invalid_Refine);
            this.St_Filters.Controls.Add(this.St_search_Status);
            this.St_Filters.Controls.Add(this.L_St_search_S);
            this.St_Filters.Controls.Add(this.L_St_search_D);
            this.St_Filters.Controls.Add(this.St_search_IV);
            this.St_Filters.Controls.Add(this.L_St_search_C);
            this.St_Filters.Controls.Add(this.L_St_search_B);
            this.St_Filters.Controls.Add(this.L_St_search_A);
            this.St_Filters.Controls.Add(this.L_St_search_H);
            this.St_Filters.Controls.Add(this.St_L_mezapa);
            this.St_Filters.Controls.Add(this.St_pokedex);
            this.St_Filters.Controls.Add(this.St_Pokemon);
            this.St_Filters.Controls.Add(this.St_mezapaType);
            this.St_Filters.Controls.Add(this.label33);
            this.St_Filters.Controls.Add(this.St_Status_display);
            this.St_Filters.Controls.Add(this.St_Lv);
            this.St_Filters.Controls.Add(this.St_IVup6);
            this.St_Filters.Controls.Add(this.St_IVlow1);
            this.St_Filters.Controls.Add(this.label34);
            this.St_Filters.Controls.Add(this.St_IVlow2);
            this.St_Filters.Controls.Add(this.St_nature);
            this.St_Filters.Controls.Add(this.St_IVlow3);
            this.St_Filters.Controls.Add(this.St_IVup5);
            this.St_Filters.Controls.Add(this.St_IVlow4);
            this.St_Filters.Controls.Add(this.label35);
            this.St_Filters.Controls.Add(this.St_IVlow5);
            this.St_Filters.Controls.Add(this.St_L_Nature);
            this.St_Filters.Controls.Add(this.St_IVlow6);
            this.St_Filters.Controls.Add(this.St_IVup4);
            this.St_Filters.Controls.Add(this.label37);
            this.St_Filters.Controls.Add(this.label38);
            this.St_Filters.Controls.Add(this.St_IVup1);
            this.St_Filters.Controls.Add(this.St_IVup3);
            this.St_Filters.Controls.Add(this.label41);
            this.St_Filters.Controls.Add(this.label42);
            this.St_Filters.Controls.Add(this.St_IVup2);
            this.St_Filters.Controls.Add(this.St_Synchro_nature);
            this.St_Filters.Location = new System.Drawing.Point(6, 141);
            this.St_Filters.Name = "St_Filters";
            this.St_Filters.Size = new System.Drawing.Size(387, 259);
            this.St_Filters.TabIndex = 1;
            this.St_Filters.TabStop = false;
            // 
            // St_stats6
            // 
            this.St_stats6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_stats6.Location = new System.Drawing.Point(41, 221);
            this.St_stats6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.St_stats6.Name = "St_stats6";
            this.St_stats6.Size = new System.Drawing.Size(119, 22);
            this.St_stats6.TabIndex = 37;
            this.St_stats6.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_stats6.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_stats3
            // 
            this.St_stats3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_stats3.Location = new System.Drawing.Point(41, 125);
            this.St_stats3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.St_stats3.Name = "St_stats3";
            this.St_stats3.Size = new System.Drawing.Size(119, 22);
            this.St_stats3.TabIndex = 34;
            this.St_stats3.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_stats3.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_stats4
            // 
            this.St_stats4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_stats4.Location = new System.Drawing.Point(41, 157);
            this.St_stats4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.St_stats4.Name = "St_stats4";
            this.St_stats4.Size = new System.Drawing.Size(119, 22);
            this.St_stats4.TabIndex = 35;
            this.St_stats4.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_stats4.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_stats5
            // 
            this.St_stats5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_stats5.Location = new System.Drawing.Point(41, 189);
            this.St_stats5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.St_stats5.Name = "St_stats5";
            this.St_stats5.Size = new System.Drawing.Size(119, 22);
            this.St_stats5.TabIndex = 36;
            this.St_stats5.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_stats5.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_stats2
            // 
            this.St_stats2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_stats2.Location = new System.Drawing.Point(41, 93);
            this.St_stats2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.St_stats2.Name = "St_stats2";
            this.St_stats2.Size = new System.Drawing.Size(119, 22);
            this.St_stats2.TabIndex = 33;
            this.St_stats2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_stats2.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_stats1
            // 
            this.St_stats1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_stats1.Location = new System.Drawing.Point(41, 61);
            this.St_stats1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.St_stats1.Name = "St_stats1";
            this.St_stats1.Size = new System.Drawing.Size(119, 22);
            this.St_stats1.TabIndex = 32;
            this.St_stats1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_stats1.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // synchro_nature
            // 
            this.synchro_nature.Location = new System.Drawing.Point(177, 98);
            this.synchro_nature.Name = "synchro_nature";
            this.synchro_nature.Size = new System.Drawing.Size(57, 18);
            this.synchro_nature.TabIndex = 189;
            this.synchro_nature.Text = "シンクロ";
            this.synchro_nature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // St_Invalid_Refine
            // 
            this.St_Invalid_Refine.AutoSize = true;
            this.St_Invalid_Refine.Location = new System.Drawing.Point(194, 223);
            this.St_Invalid_Refine.Name = "St_Invalid_Refine";
            this.St_Invalid_Refine.Size = new System.Drawing.Size(100, 16);
            this.St_Invalid_Refine.TabIndex = 43;
            this.St_Invalid_Refine.Text = "絞り込みを無効";
            this.St_Invalid_Refine.UseVisualStyleBackColor = true;
            // 
            // St_search_Status
            // 
            this.St_search_Status.AutoSize = true;
            this.St_search_Status.BackColor = System.Drawing.Color.White;
            this.St_search_Status.Location = new System.Drawing.Point(131, 0);
            this.St_search_Status.Name = "St_search_Status";
            this.St_search_Status.Size = new System.Drawing.Size(101, 16);
            this.St_search_Status.TabIndex = 11;
            this.St_search_Status.Text = "能力値から検索";
            this.St_search_Status.UseVisualStyleBackColor = false;
            // 
            // L_St_search_S
            // 
            this.L_St_search_S.Location = new System.Drawing.Point(-5, 226);
            this.L_St_search_S.Name = "L_St_search_S";
            this.L_St_search_S.Size = new System.Drawing.Size(40, 18);
            this.L_St_search_S.TabIndex = 48;
            this.L_St_search_S.Text = "S";
            this.L_St_search_S.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_St_search_D
            // 
            this.L_St_search_D.Location = new System.Drawing.Point(-5, 194);
            this.L_St_search_D.Name = "L_St_search_D";
            this.L_St_search_D.Size = new System.Drawing.Size(40, 18);
            this.L_St_search_D.TabIndex = 46;
            this.L_St_search_D.Text = "D";
            this.L_St_search_D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // St_search_IV
            // 
            this.St_search_IV.AutoSize = true;
            this.St_search_IV.BackColor = System.Drawing.Color.White;
            this.St_search_IV.Checked = true;
            this.St_search_IV.Location = new System.Drawing.Point(24, 0);
            this.St_search_IV.Name = "St_search_IV";
            this.St_search_IV.Size = new System.Drawing.Size(105, 16);
            this.St_search_IV.TabIndex = 10;
            this.St_search_IV.TabStop = true;
            this.St_search_IV.Text = "個体値から検索 ";
            this.St_search_IV.UseVisualStyleBackColor = false;
            this.St_search_IV.CheckedChanged += new System.EventHandler(this.St_search_IV_CheckedChanged);
            // 
            // L_St_search_C
            // 
            this.L_St_search_C.Location = new System.Drawing.Point(-5, 162);
            this.L_St_search_C.Name = "L_St_search_C";
            this.L_St_search_C.Size = new System.Drawing.Size(40, 18);
            this.L_St_search_C.TabIndex = 44;
            this.L_St_search_C.Text = "C";
            this.L_St_search_C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_St_search_B
            // 
            this.L_St_search_B.Location = new System.Drawing.Point(-5, 130);
            this.L_St_search_B.Name = "L_St_search_B";
            this.L_St_search_B.Size = new System.Drawing.Size(40, 18);
            this.L_St_search_B.TabIndex = 42;
            this.L_St_search_B.Text = "B";
            this.L_St_search_B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_St_search_A
            // 
            this.L_St_search_A.Location = new System.Drawing.Point(-5, 98);
            this.L_St_search_A.Name = "L_St_search_A";
            this.L_St_search_A.Size = new System.Drawing.Size(40, 18);
            this.L_St_search_A.TabIndex = 40;
            this.L_St_search_A.Text = "A";
            this.L_St_search_A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_St_search_H
            // 
            this.L_St_search_H.Location = new System.Drawing.Point(-5, 66);
            this.L_St_search_H.Name = "L_St_search_H";
            this.L_St_search_H.Size = new System.Drawing.Size(40, 18);
            this.L_St_search_H.TabIndex = 38;
            this.L_St_search_H.Text = "H";
            this.L_St_search_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // St_L_mezapa
            // 
            this.St_L_mezapa.Location = new System.Drawing.Point(177, 130);
            this.St_L_mezapa.Name = "St_L_mezapa";
            this.St_L_mezapa.Size = new System.Drawing.Size(57, 18);
            this.St_L_mezapa.TabIndex = 97;
            this.St_L_mezapa.Text = "めざパ";
            this.St_L_mezapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // St_pokedex
            // 
            this.St_pokedex.FormattingEnabled = true;
            this.St_pokedex.Location = new System.Drawing.Point(70, 27);
            this.St_pokedex.Name = "St_pokedex";
            this.St_pokedex.Size = new System.Drawing.Size(90, 20);
            this.St_pokedex.TabIndex = 12;
            this.St_pokedex.SelectedIndexChanged += new System.EventHandler(this.ChangePoke);
            // 
            // St_Pokemon
            // 
            this.St_Pokemon.Location = new System.Drawing.Point(12, 30);
            this.St_Pokemon.Name = "St_Pokemon";
            this.St_Pokemon.Size = new System.Drawing.Size(52, 12);
            this.St_Pokemon.TabIndex = 64;
            this.St_Pokemon.Text = "ポケモン";
            this.St_Pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // St_mezapaType
            // 
            this.St_mezapaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.St_mezapaType.FormattingEnabled = true;
            this.St_mezapaType.Location = new System.Drawing.Point(241, 127);
            this.St_mezapaType.Name = "St_mezapaType";
            this.St_mezapaType.Size = new System.Drawing.Size(80, 20);
            this.St_mezapaType.TabIndex = 42;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(174, 30);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(17, 12);
            this.label33.TabIndex = 67;
            this.label33.Text = "Lv";
            // 
            // St_Status_display
            // 
            this.St_Status_display.AutoSize = true;
            this.St_Status_display.BackColor = System.Drawing.Color.Transparent;
            this.St_Status_display.Location = new System.Drawing.Point(258, 29);
            this.St_Status_display.Name = "St_Status_display";
            this.St_Status_display.Size = new System.Drawing.Size(112, 16);
            this.St_Status_display.TabIndex = 14;
            this.St_Status_display.Text = "能力値を表示する";
            this.St_Status_display.UseVisualStyleBackColor = false;
            this.St_Status_display.Click += new System.EventHandler(this.St_check_display_Click);
            // 
            // St_Lv
            // 
            this.St_Lv.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Lv.Location = new System.Drawing.Point(197, 25);
            this.St_Lv.Name = "St_Lv";
            this.St_Lv.Size = new System.Drawing.Size(50, 22);
            this.St_Lv.TabIndex = 13;
            this.St_Lv.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.St_Lv.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_Lv.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_IVup6
            // 
            this.St_IVup6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVup6.Location = new System.Drawing.Point(115, 221);
            this.St_IVup6.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup6.Name = "St_IVup6";
            this.St_IVup6.Size = new System.Drawing.Size(45, 22);
            this.St_IVup6.TabIndex = 31;
            this.St_IVup6.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup6.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVup6.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_IVlow1
            // 
            this.St_IVlow1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVlow1.Location = new System.Drawing.Point(41, 61);
            this.St_IVlow1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVlow1.Name = "St_IVlow1";
            this.St_IVlow1.Size = new System.Drawing.Size(45, 22);
            this.St_IVlow1.TabIndex = 20;
            this.St_IVlow1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVlow1.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(92, 226);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(17, 12);
            this.label34.TabIndex = 86;
            this.label34.Text = "～";
            // 
            // St_IVlow2
            // 
            this.St_IVlow2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVlow2.Location = new System.Drawing.Point(41, 93);
            this.St_IVlow2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVlow2.Name = "St_IVlow2";
            this.St_IVlow2.Size = new System.Drawing.Size(45, 22);
            this.St_IVlow2.TabIndex = 22;
            this.St_IVlow2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVlow2.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_nature
            // 
            this.St_nature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.St_nature.FormattingEnabled = true;
            this.St_nature.Location = new System.Drawing.Point(241, 63);
            this.St_nature.Name = "St_nature";
            this.St_nature.Size = new System.Drawing.Size(80, 20);
            this.St_nature.TabIndex = 40;
            // 
            // St_IVlow3
            // 
            this.St_IVlow3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVlow3.Location = new System.Drawing.Point(41, 125);
            this.St_IVlow3.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVlow3.Name = "St_IVlow3";
            this.St_IVlow3.Size = new System.Drawing.Size(45, 22);
            this.St_IVlow3.TabIndex = 24;
            this.St_IVlow3.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVlow3.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_IVup5
            // 
            this.St_IVup5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVup5.Location = new System.Drawing.Point(115, 189);
            this.St_IVup5.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup5.Name = "St_IVup5";
            this.St_IVup5.Size = new System.Drawing.Size(45, 22);
            this.St_IVup5.TabIndex = 29;
            this.St_IVup5.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup5.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVup5.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_IVlow4
            // 
            this.St_IVlow4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVlow4.Location = new System.Drawing.Point(41, 157);
            this.St_IVlow4.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVlow4.Name = "St_IVlow4";
            this.St_IVlow4.Size = new System.Drawing.Size(45, 22);
            this.St_IVlow4.TabIndex = 26;
            this.St_IVlow4.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVlow4.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(92, 194);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(17, 12);
            this.label35.TabIndex = 84;
            this.label35.Text = "～";
            // 
            // St_IVlow5
            // 
            this.St_IVlow5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVlow5.Location = new System.Drawing.Point(41, 189);
            this.St_IVlow5.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVlow5.Name = "St_IVlow5";
            this.St_IVlow5.Size = new System.Drawing.Size(45, 22);
            this.St_IVlow5.TabIndex = 28;
            this.St_IVlow5.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVlow5.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_L_Nature
            // 
            this.St_L_Nature.Location = new System.Drawing.Point(177, 66);
            this.St_L_Nature.Name = "St_L_Nature";
            this.St_L_Nature.Size = new System.Drawing.Size(57, 18);
            this.St_L_Nature.TabIndex = 66;
            this.St_L_Nature.Text = "性格";
            this.St_L_Nature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // St_IVlow6
            // 
            this.St_IVlow6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVlow6.Location = new System.Drawing.Point(41, 221);
            this.St_IVlow6.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVlow6.Name = "St_IVlow6";
            this.St_IVlow6.Size = new System.Drawing.Size(45, 22);
            this.St_IVlow6.TabIndex = 30;
            this.St_IVlow6.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVlow6.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_IVup4
            // 
            this.St_IVup4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVup4.Location = new System.Drawing.Point(115, 157);
            this.St_IVup4.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup4.Name = "St_IVup4";
            this.St_IVup4.Size = new System.Drawing.Size(45, 22);
            this.St_IVup4.TabIndex = 27;
            this.St_IVup4.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup4.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVup4.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(92, 66);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(17, 12);
            this.label37.TabIndex = 76;
            this.label37.Text = "～";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(92, 162);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(17, 12);
            this.label38.TabIndex = 82;
            this.label38.Text = "～";
            // 
            // St_IVup1
            // 
            this.St_IVup1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVup1.Location = new System.Drawing.Point(115, 61);
            this.St_IVup1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup1.Name = "St_IVup1";
            this.St_IVup1.Size = new System.Drawing.Size(45, 22);
            this.St_IVup1.TabIndex = 21;
            this.St_IVup1.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup1.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVup1.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_IVup3
            // 
            this.St_IVup3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVup3.Location = new System.Drawing.Point(115, 125);
            this.St_IVup3.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup3.Name = "St_IVup3";
            this.St_IVup3.Size = new System.Drawing.Size(45, 22);
            this.St_IVup3.TabIndex = 25;
            this.St_IVup3.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup3.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVup3.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(92, 98);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(17, 12);
            this.label41.TabIndex = 78;
            this.label41.Text = "～";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(92, 130);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(17, 12);
            this.label42.TabIndex = 80;
            this.label42.Text = "～";
            // 
            // St_IVup2
            // 
            this.St_IVup2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_IVup2.Location = new System.Drawing.Point(115, 93);
            this.St_IVup2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup2.Name = "St_IVup2";
            this.St_IVup2.Size = new System.Drawing.Size(45, 22);
            this.St_IVup2.TabIndex = 23;
            this.St_IVup2.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.St_IVup2.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.St_IVup2.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // St_Synchro_nature
            // 
            this.St_Synchro_nature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.St_Synchro_nature.FormattingEnabled = true;
            this.St_Synchro_nature.Location = new System.Drawing.Point(241, 95);
            this.St_Synchro_nature.Name = "St_Synchro_nature";
            this.St_Synchro_nature.Size = new System.Drawing.Size(80, 20);
            this.St_Synchro_nature.TabIndex = 41;
            // 
            // Stationary_List
            // 
            this.Stationary_List.Enabled = false;
            this.Stationary_List.Location = new System.Drawing.Point(318, 471);
            this.Stationary_List.Name = "Stationary_List";
            this.Stationary_List.Size = new System.Drawing.Size(75, 23);
            this.Stationary_List.TabIndex = 61;
            this.Stationary_List.Text = "リスト表示";
            this.Stationary_List.UseVisualStyleBackColor = true;
            // 
            // St_dataGridView
            // 
            this.St_dataGridView.AllowUserToAddRows = false;
            this.St_dataGridView.AllowUserToDeleteRows = false;
            this.St_dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.St_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.St_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.St_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.St_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSt_frame,
            this.dgvSt_tolerance,
            this.dgvSt_H,
            this.dgvSt_A,
            this.dgvSt_B,
            this.dgvSt_C,
            this.dgvSt_D,
            this.dgvSt_S,
            this.dgvSt_nature,
            this.dgvSt_Synchronize,
            this.dgvSt_H_Status,
            this.dgvSt_A_Status,
            this.dgvSt_B_Status,
            this.dgvSt_C_Status,
            this.dgvSt_D_Status,
            this.dgvSt_S_Status,
            this.dgvSt_psv,
            this.St_Clock,
            this.dgvSt_rand});
            this.St_dataGridView.Location = new System.Drawing.Point(399, 4);
            this.St_dataGridView.Name = "St_dataGridView";
            this.St_dataGridView.ReadOnly = true;
            this.St_dataGridView.RowTemplate.Height = 21;
            this.St_dataGridView.Size = new System.Drawing.Size(711, 490);
            this.St_dataGridView.TabIndex = 0;
            this.St_dataGridView.TabStop = false;
            // 
            // dgvSt_frame
            // 
            this.dgvSt_frame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvSt_frame.HeaderText = "F";
            this.dgvSt_frame.Name = "dgvSt_frame";
            this.dgvSt_frame.ReadOnly = true;
            this.dgvSt_frame.Width = 37;
            // 
            // dgvSt_tolerance
            // 
            this.dgvSt_tolerance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvSt_tolerance.HeaderText = "ずれ";
            this.dgvSt_tolerance.Name = "dgvSt_tolerance";
            this.dgvSt_tolerance.ReadOnly = true;
            this.dgvSt_tolerance.Width = 51;
            // 
            // dgvSt_H
            // 
            this.dgvSt_H.HeaderText = "H";
            this.dgvSt_H.Name = "dgvSt_H";
            this.dgvSt_H.ReadOnly = true;
            this.dgvSt_H.Width = 27;
            // 
            // dgvSt_A
            // 
            this.dgvSt_A.HeaderText = "A";
            this.dgvSt_A.Name = "dgvSt_A";
            this.dgvSt_A.ReadOnly = true;
            this.dgvSt_A.Width = 27;
            // 
            // dgvSt_B
            // 
            this.dgvSt_B.HeaderText = "B";
            this.dgvSt_B.Name = "dgvSt_B";
            this.dgvSt_B.ReadOnly = true;
            this.dgvSt_B.Width = 27;
            // 
            // dgvSt_C
            // 
            this.dgvSt_C.HeaderText = "C";
            this.dgvSt_C.Name = "dgvSt_C";
            this.dgvSt_C.ReadOnly = true;
            this.dgvSt_C.Width = 27;
            // 
            // dgvSt_D
            // 
            this.dgvSt_D.HeaderText = "D";
            this.dgvSt_D.Name = "dgvSt_D";
            this.dgvSt_D.ReadOnly = true;
            this.dgvSt_D.Width = 27;
            // 
            // dgvSt_S
            // 
            this.dgvSt_S.HeaderText = "S";
            this.dgvSt_S.Name = "dgvSt_S";
            this.dgvSt_S.ReadOnly = true;
            this.dgvSt_S.Width = 27;
            // 
            // dgvSt_nature
            // 
            this.dgvSt_nature.HeaderText = "性格";
            this.dgvSt_nature.Name = "dgvSt_nature";
            this.dgvSt_nature.ReadOnly = true;
            this.dgvSt_nature.Width = 60;
            // 
            // dgvSt_Synchronize
            // 
            this.dgvSt_Synchronize.HeaderText = "シンクロ";
            this.dgvSt_Synchronize.Name = "dgvSt_Synchronize";
            this.dgvSt_Synchronize.ReadOnly = true;
            this.dgvSt_Synchronize.Width = 64;
            // 
            // dgvSt_H_Status
            // 
            this.dgvSt_H_Status.HeaderText = "H";
            this.dgvSt_H_Status.Name = "dgvSt_H_Status";
            this.dgvSt_H_Status.ReadOnly = true;
            this.dgvSt_H_Status.Width = 30;
            // 
            // dgvSt_A_Status
            // 
            this.dgvSt_A_Status.HeaderText = "A";
            this.dgvSt_A_Status.Name = "dgvSt_A_Status";
            this.dgvSt_A_Status.ReadOnly = true;
            this.dgvSt_A_Status.Width = 30;
            // 
            // dgvSt_B_Status
            // 
            this.dgvSt_B_Status.HeaderText = "B";
            this.dgvSt_B_Status.Name = "dgvSt_B_Status";
            this.dgvSt_B_Status.ReadOnly = true;
            this.dgvSt_B_Status.Width = 30;
            // 
            // dgvSt_C_Status
            // 
            this.dgvSt_C_Status.HeaderText = "C";
            this.dgvSt_C_Status.Name = "dgvSt_C_Status";
            this.dgvSt_C_Status.ReadOnly = true;
            this.dgvSt_C_Status.Width = 30;
            // 
            // dgvSt_D_Status
            // 
            this.dgvSt_D_Status.HeaderText = "D";
            this.dgvSt_D_Status.Name = "dgvSt_D_Status";
            this.dgvSt_D_Status.ReadOnly = true;
            this.dgvSt_D_Status.Width = 30;
            // 
            // dgvSt_S_Status
            // 
            this.dgvSt_S_Status.HeaderText = "S";
            this.dgvSt_S_Status.Name = "dgvSt_S_Status";
            this.dgvSt_S_Status.ReadOnly = true;
            this.dgvSt_S_Status.Width = 30;
            // 
            // dgvSt_psv
            // 
            this.dgvSt_psv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvSt_psv.HeaderText = "PSV";
            this.dgvSt_psv.Name = "dgvSt_psv";
            this.dgvSt_psv.ReadOnly = true;
            this.dgvSt_psv.Width = 52;
            // 
            // St_Clock
            // 
            this.St_Clock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.St_Clock.HeaderText = "針";
            this.St_Clock.Name = "St_Clock";
            this.St_Clock.ReadOnly = true;
            this.St_Clock.Width = 42;
            // 
            // dgvSt_rand
            // 
            this.dgvSt_rand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvSt_rand.HeaderText = "乱数値";
            this.dgvSt_rand.Name = "dgvSt_rand";
            this.dgvSt_rand.ReadOnly = true;
            this.dgvSt_rand.Width = 66;
            // 
            // Stationary_Search
            // 
            this.Stationary_Search.Location = new System.Drawing.Point(318, 442);
            this.Stationary_Search.Name = "Stationary_Search";
            this.Stationary_Search.Size = new System.Drawing.Size(75, 23);
            this.Stationary_Search.TabIndex = 60;
            this.Stationary_Search.Text = "計算";
            this.Stationary_Search.UseVisualStyleBackColor = true;
            this.Stationary_Search.Click += new System.EventHandler(this.Stationary_Search_Click);
            // 
            // Tab_StationaryClock
            // 
            this.Tab_StationaryClock.Controls.Add(this.Calc_Frame_Info);
            this.Tab_StationaryClock.Controls.Add(this.Clock_RNGInfo);
            this.Tab_StationaryClock.Controls.Add(this.Clock_groupBox);
            this.Tab_StationaryClock.Location = new System.Drawing.Point(4, 22);
            this.Tab_StationaryClock.Name = "Tab_StationaryClock";
            this.Tab_StationaryClock.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_StationaryClock.Size = new System.Drawing.Size(1116, 500);
            this.Tab_StationaryClock.TabIndex = 1;
            this.Tab_StationaryClock.Text = "針検索";
            this.Tab_StationaryClock.UseVisualStyleBackColor = true;
            // 
            // Calc_Frame_Info
            // 
            this.Calc_Frame_Info.Controls.Add(this.qty_NPC);
            this.Calc_Frame_Info.Controls.Add(this.NPC);
            this.Calc_Frame_Info.Controls.Add(this.Calc_Output);
            this.Calc_Frame_Info.Controls.Add(this.Calc_Frame);
            this.Calc_Frame_Info.Controls.Add(this.Calc_InitialSeed);
            this.Calc_Frame_Info.Controls.Add(this.label24);
            this.Calc_Frame_Info.Controls.Add(this.St_Clock_Time_Frame);
            this.Calc_Frame_Info.Controls.Add(this.label26);
            this.Calc_Frame_Info.Controls.Add(this.St_Clock_Time_InitialSeed);
            this.Calc_Frame_Info.Controls.Add(this.Calc_min);
            this.Calc_Frame_Info.Controls.Add(this.Calc_max);
            this.Calc_Frame_Info.Location = new System.Drawing.Point(346, 157);
            this.Calc_Frame_Info.Name = "Calc_Frame_Info";
            this.Calc_Frame_Info.Size = new System.Drawing.Size(334, 337);
            this.Calc_Frame_Info.TabIndex = 2;
            this.Calc_Frame_Info.TabStop = false;
            this.Calc_Frame_Info.Text = "待機Frame計算";
            // 
            // qty_NPC
            // 
            this.qty_NPC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_NPC.Location = new System.Drawing.Point(7, 95);
            this.qty_NPC.Name = "qty_NPC";
            this.qty_NPC.Size = new System.Drawing.Size(93, 28);
            this.qty_NPC.TabIndex = 83;
            this.qty_NPC.Text = "NPCの数";
            this.qty_NPC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NPC
            // 
            this.NPC.Font = new System.Drawing.Font("Consolas", 9F);
            this.NPC.Location = new System.Drawing.Point(112, 93);
            this.NPC.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NPC.Name = "NPC";
            this.NPC.Size = new System.Drawing.Size(62, 22);
            this.NPC.TabIndex = 83;
            // 
            // Calc_Output
            // 
            this.Calc_Output.FormattingEnabled = true;
            this.Calc_Output.ItemHeight = 12;
            this.Calc_Output.Location = new System.Drawing.Point(6, 159);
            this.Calc_Output.Name = "Calc_Output";
            this.Calc_Output.Size = new System.Drawing.Size(322, 172);
            this.Calc_Output.TabIndex = 82;
            // 
            // Calc_Frame
            // 
            this.Calc_Frame.Location = new System.Drawing.Point(253, 130);
            this.Calc_Frame.Name = "Calc_Frame";
            this.Calc_Frame.Size = new System.Drawing.Size(75, 23);
            this.Calc_Frame.TabIndex = 23;
            this.Calc_Frame.Text = "計算";
            this.Calc_Frame.UseVisualStyleBackColor = true;
            this.Calc_Frame.Click += new System.EventHandler(this.Calc_Frame_Click);
            // 
            // Calc_InitialSeed
            // 
            this.Calc_InitialSeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_InitialSeed.Hexadecimal = true;
            this.Calc_InitialSeed.Location = new System.Drawing.Point(112, 27);
            this.Calc_InitialSeed.Name = "Calc_InitialSeed";
            this.Calc_InitialSeed.Size = new System.Drawing.Size(80, 22);
            this.Calc_InitialSeed.TabIndex = 20;
            this.Calc_InitialSeed.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.Calc_InitialSeed.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(85, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 14);
            this.label24.TabIndex = 71;
            this.label24.Text = "0x";
            // 
            // St_Clock_Time_Frame
            // 
            this.St_Clock_Time_Frame.AutoSize = true;
            this.St_Clock_Time_Frame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Clock_Time_Frame.Location = new System.Drawing.Point(58, 62);
            this.St_Clock_Time_Frame.Name = "St_Clock_Time_Frame";
            this.St_Clock_Time_Frame.Size = new System.Drawing.Size(42, 14);
            this.St_Clock_Time_Frame.TabIndex = 64;
            this.St_Clock_Time_Frame.Text = "Frame";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(198, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 16);
            this.label26.TabIndex = 61;
            this.label26.Text = "～";
            // 
            // St_Clock_Time_InitialSeed
            // 
            this.St_Clock_Time_InitialSeed.Font = new System.Drawing.Font("Consolas", 9F);
            this.St_Clock_Time_InitialSeed.Location = new System.Drawing.Point(0, 29);
            this.St_Clock_Time_InitialSeed.Name = "St_Clock_Time_InitialSeed";
            this.St_Clock_Time_InitialSeed.Size = new System.Drawing.Size(80, 28);
            this.St_Clock_Time_InitialSeed.TabIndex = 72;
            this.St_Clock_Time_InitialSeed.Text = "初期seed";
            this.St_Clock_Time_InitialSeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Calc_min
            // 
            this.Calc_min.Font = new System.Drawing.Font("Consolas", 9F);
            this.Calc_min.Location = new System.Drawing.Point(112, 60);
            this.Calc_min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Calc_min.Name = "Calc_min";
            this.Calc_min.Size = new System.Drawing.Size(80, 22);
            this.Calc_min.TabIndex = 21;
            this.Calc_min.Value = new decimal(new int[] {
            417,
            0,
            0,
            0});
            this.Calc_min.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.Calc_min.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // Calc_max
            // 
            this.Calc_max.Font = new System.Drawing.Font("Consolas", 9F);
            this.Calc_max.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Calc_max.Location = new System.Drawing.Point(222, 60);
            this.Calc_max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Calc_max.Name = "Calc_max";
            this.Calc_max.Size = new System.Drawing.Size(80, 22);
            this.Calc_max.TabIndex = 22;
            this.Calc_max.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Calc_max.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.Calc_max.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // Clock_RNGInfo
            // 
            this.Clock_RNGInfo.Controls.Add(this.Search_Clock);
            this.Clock_RNGInfo.Controls.Add(this.St_Clocklist);
            this.Clock_RNGInfo.Controls.Add(this.Clock_CurrentFrame);
            this.Clock_RNGInfo.Controls.Add(this.Clock_SearchList);
            this.Clock_RNGInfo.Controls.Add(this.Clock_InitialSeed);
            this.Clock_RNGInfo.Controls.Add(this.label17);
            this.Clock_RNGInfo.Controls.Add(this.St_Clock_Search_Frame);
            this.Clock_RNGInfo.Controls.Add(this.label22);
            this.Clock_RNGInfo.Controls.Add(this.St_Clock_Search_InitialSeed);
            this.Clock_RNGInfo.Controls.Add(this.Clock_min);
            this.Clock_RNGInfo.Controls.Add(this.Clock_max);
            this.Clock_RNGInfo.Location = new System.Drawing.Point(6, 157);
            this.Clock_RNGInfo.Name = "Clock_RNGInfo";
            this.Clock_RNGInfo.Size = new System.Drawing.Size(334, 337);
            this.Clock_RNGInfo.TabIndex = 1;
            this.Clock_RNGInfo.TabStop = false;
            this.Clock_RNGInfo.Text = "現在位置検索";
            // 
            // Search_Clock
            // 
            this.Search_Clock.FormattingEnabled = true;
            this.Search_Clock.ItemHeight = 12;
            this.Search_Clock.Location = new System.Drawing.Point(6, 159);
            this.Search_Clock.Name = "Search_Clock";
            this.Search_Clock.Size = new System.Drawing.Size(322, 172);
            this.Search_Clock.TabIndex = 56;
            // 
            // St_Clocklist
            // 
            this.St_Clocklist.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Clocklist.Location = new System.Drawing.Point(8, 96);
            this.St_Clocklist.Name = "St_Clocklist";
            this.St_Clocklist.Size = new System.Drawing.Size(93, 14);
            this.St_Clocklist.TabIndex = 82;
            this.St_Clocklist.Text = "針リスト";
            this.St_Clocklist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Clock_CurrentFrame
            // 
            this.Clock_CurrentFrame.Location = new System.Drawing.Point(253, 130);
            this.Clock_CurrentFrame.Name = "Clock_CurrentFrame";
            this.Clock_CurrentFrame.Size = new System.Drawing.Size(75, 23);
            this.Clock_CurrentFrame.TabIndex = 14;
            this.Clock_CurrentFrame.Text = "計算";
            this.Clock_CurrentFrame.UseVisualStyleBackColor = true;
            this.Clock_CurrentFrame.Click += new System.EventHandler(this.Clock_CurrentFrame_Click);
            // 
            // Clock_SearchList
            // 
            this.Clock_SearchList.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_SearchList.Location = new System.Drawing.Point(112, 93);
            this.Clock_SearchList.Name = "Clock_SearchList";
            this.Clock_SearchList.Size = new System.Drawing.Size(192, 22);
            this.Clock_SearchList.TabIndex = 13;
            // 
            // Clock_InitialSeed
            // 
            this.Clock_InitialSeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_InitialSeed.Hexadecimal = true;
            this.Clock_InitialSeed.Location = new System.Drawing.Point(112, 27);
            this.Clock_InitialSeed.Name = "Clock_InitialSeed";
            this.Clock_InitialSeed.Size = new System.Drawing.Size(80, 22);
            this.Clock_InitialSeed.TabIndex = 10;
            this.Clock_InitialSeed.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.Clock_InitialSeed.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(85, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 14);
            this.label17.TabIndex = 71;
            this.label17.Text = "0x";
            // 
            // St_Clock_Search_Frame
            // 
            this.St_Clock_Search_Frame.AutoSize = true;
            this.St_Clock_Search_Frame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_Clock_Search_Frame.Location = new System.Drawing.Point(58, 62);
            this.St_Clock_Search_Frame.Name = "St_Clock_Search_Frame";
            this.St_Clock_Search_Frame.Size = new System.Drawing.Size(42, 14);
            this.St_Clock_Search_Frame.TabIndex = 64;
            this.St_Clock_Search_Frame.Text = "Frame";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(198, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 16);
            this.label22.TabIndex = 61;
            this.label22.Text = "～";
            // 
            // St_Clock_Search_InitialSeed
            // 
            this.St_Clock_Search_InitialSeed.Font = new System.Drawing.Font("Consolas", 9F);
            this.St_Clock_Search_InitialSeed.Location = new System.Drawing.Point(0, 29);
            this.St_Clock_Search_InitialSeed.Name = "St_Clock_Search_InitialSeed";
            this.St_Clock_Search_InitialSeed.Size = new System.Drawing.Size(80, 28);
            this.St_Clock_Search_InitialSeed.TabIndex = 72;
            this.St_Clock_Search_InitialSeed.Text = "初期seed";
            this.St_Clock_Search_InitialSeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Clock_min
            // 
            this.Clock_min.Font = new System.Drawing.Font("Consolas", 9F);
            this.Clock_min.Location = new System.Drawing.Point(112, 60);
            this.Clock_min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Clock_min.Name = "Clock_min";
            this.Clock_min.Size = new System.Drawing.Size(80, 22);
            this.Clock_min.TabIndex = 11;
            this.Clock_min.Value = new decimal(new int[] {
            417,
            0,
            0,
            0});
            this.Clock_min.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.Clock_min.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // Clock_max
            // 
            this.Clock_max.Font = new System.Drawing.Font("Consolas", 9F);
            this.Clock_max.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Clock_max.Location = new System.Drawing.Point(222, 60);
            this.Clock_max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Clock_max.Name = "Clock_max";
            this.Clock_max.Size = new System.Drawing.Size(80, 22);
            this.Clock_max.TabIndex = 12;
            this.Clock_max.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Clock_max.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.Clock_max.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpDown_Check);
            // 
            // Clock_groupBox
            // 
            this.Clock_groupBox.Controls.Add(this.TB_Candidate_InitSeed);
            this.Clock_groupBox.Controls.Add(this.L_Candidate_InitSeed);
            this.Clock_groupBox.Controls.Add(this.Delete);
            this.Clock_groupBox.Controls.Add(this.Back);
            this.Clock_groupBox.Controls.Add(this.Clock_List);
            this.Clock_groupBox.Controls.Add(this.clock_end);
            this.Clock_groupBox.Controls.Add(this.clock_begin);
            this.Clock_groupBox.Controls.Add(this.button_Clock_16);
            this.Clock_groupBox.Controls.Add(this.button_Clock_15);
            this.Clock_groupBox.Controls.Add(this.button_Clock_14);
            this.Clock_groupBox.Controls.Add(this.button_Clock_13);
            this.Clock_groupBox.Controls.Add(this.button_Clock_12);
            this.Clock_groupBox.Controls.Add(this.button_Clock_11);
            this.Clock_groupBox.Controls.Add(this.button_Clock_10);
            this.Clock_groupBox.Controls.Add(this.button_Clock_9);
            this.Clock_groupBox.Controls.Add(this.button_Clock_8);
            this.Clock_groupBox.Controls.Add(this.button_Clock_7);
            this.Clock_groupBox.Controls.Add(this.button_Clock_6);
            this.Clock_groupBox.Controls.Add(this.button_Clock_5);
            this.Clock_groupBox.Controls.Add(this.button_Clock_4);
            this.Clock_groupBox.Controls.Add(this.button_Clock_3);
            this.Clock_groupBox.Controls.Add(this.button_Clock_2);
            this.Clock_groupBox.Controls.Add(this.button_Clock_1);
            this.Clock_groupBox.Controls.Add(this.button_Clock_0);
            this.Clock_groupBox.Controls.Add(this.Clock_3);
            this.Clock_groupBox.Controls.Add(this.Clock_0);
            this.Clock_groupBox.Controls.Add(this.Clock_16);
            this.Clock_groupBox.Controls.Add(this.Clock_1);
            this.Clock_groupBox.Controls.Add(this.Clock_15);
            this.Clock_groupBox.Controls.Add(this.Clock_2);
            this.Clock_groupBox.Controls.Add(this.Clock_14);
            this.Clock_groupBox.Controls.Add(this.Clock_4);
            this.Clock_groupBox.Controls.Add(this.Clock_13);
            this.Clock_groupBox.Controls.Add(this.Clock_5);
            this.Clock_groupBox.Controls.Add(this.Clock_12);
            this.Clock_groupBox.Controls.Add(this.Clock_6);
            this.Clock_groupBox.Controls.Add(this.Clock_11);
            this.Clock_groupBox.Controls.Add(this.Clock_7);
            this.Clock_groupBox.Controls.Add(this.Clock_10);
            this.Clock_groupBox.Controls.Add(this.Clock_8);
            this.Clock_groupBox.Controls.Add(this.Clock_9);
            this.Clock_groupBox.Location = new System.Drawing.Point(6, 6);
            this.Clock_groupBox.Name = "Clock_groupBox";
            this.Clock_groupBox.Size = new System.Drawing.Size(1104, 145);
            this.Clock_groupBox.TabIndex = 0;
            this.Clock_groupBox.TabStop = false;
            this.Clock_groupBox.Text = "針入力";
            // 
            // TB_Candidate_InitSeed
            // 
            this.TB_Candidate_InitSeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Candidate_InitSeed.Location = new System.Drawing.Point(896, 109);
            this.TB_Candidate_InitSeed.Name = "TB_Candidate_InitSeed";
            this.TB_Candidate_InitSeed.Size = new System.Drawing.Size(202, 22);
            this.TB_Candidate_InitSeed.TabIndex = 38;
            // 
            // L_Candidate_InitSeed
            // 
            this.L_Candidate_InitSeed.Location = new System.Drawing.Point(808, 113);
            this.L_Candidate_InitSeed.Name = "L_Candidate_InitSeed";
            this.L_Candidate_InitSeed.Size = new System.Drawing.Size(80, 48);
            this.L_Candidate_InitSeed.TabIndex = 37;
            this.L_Candidate_InitSeed.Text = "初期seed候補";
            this.L_Candidate_InitSeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(1034, 45);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(64, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "消去";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1034, 74);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(64, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "1つ戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Clock_List
            // 
            this.Clock_List.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_List.Location = new System.Drawing.Point(815, 75);
            this.Clock_List.Name = "Clock_List";
            this.Clock_List.Size = new System.Drawing.Size(213, 22);
            this.Clock_List.TabIndex = 1;
            // 
            // clock_end
            // 
            this.clock_end.AutoSize = true;
            this.clock_end.Location = new System.Drawing.Point(815, 50);
            this.clock_end.Name = "clock_end";
            this.clock_end.Size = new System.Drawing.Size(93, 16);
            this.clock_end.TabIndex = 36;
            this.clock_end.Text = "終了時の位置";
            this.clock_end.UseVisualStyleBackColor = true;
            // 
            // clock_begin
            // 
            this.clock_begin.AutoSize = true;
            this.clock_begin.Checked = true;
            this.clock_begin.Location = new System.Drawing.Point(815, 28);
            this.clock_begin.Name = "clock_begin";
            this.clock_begin.Size = new System.Drawing.Size(93, 16);
            this.clock_begin.TabIndex = 35;
            this.clock_begin.TabStop = true;
            this.clock_begin.Text = "開始時の位置";
            this.clock_begin.UseVisualStyleBackColor = true;
            // 
            // button_Clock_16
            // 
            this.button_Clock_16.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_16.Location = new System.Drawing.Point(754, 74);
            this.button_Clock_16.Name = "button_Clock_16";
            this.button_Clock_16.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_16.TabIndex = 34;
            this.button_Clock_16.Text = "16";
            this.button_Clock_16.UseVisualStyleBackColor = true;
            this.button_Clock_16.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_15
            // 
            this.button_Clock_15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_15.Location = new System.Drawing.Point(708, 74);
            this.button_Clock_15.Name = "button_Clock_15";
            this.button_Clock_15.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_15.TabIndex = 33;
            this.button_Clock_15.Text = "15";
            this.button_Clock_15.UseVisualStyleBackColor = true;
            this.button_Clock_15.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_14
            // 
            this.button_Clock_14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_14.Location = new System.Drawing.Point(662, 74);
            this.button_Clock_14.Name = "button_Clock_14";
            this.button_Clock_14.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_14.TabIndex = 32;
            this.button_Clock_14.Text = "14";
            this.button_Clock_14.UseVisualStyleBackColor = true;
            this.button_Clock_14.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_13
            // 
            this.button_Clock_13.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_13.Location = new System.Drawing.Point(616, 74);
            this.button_Clock_13.Name = "button_Clock_13";
            this.button_Clock_13.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_13.TabIndex = 31;
            this.button_Clock_13.Text = "13";
            this.button_Clock_13.UseVisualStyleBackColor = true;
            this.button_Clock_13.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_12
            // 
            this.button_Clock_12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_12.Location = new System.Drawing.Point(570, 74);
            this.button_Clock_12.Name = "button_Clock_12";
            this.button_Clock_12.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_12.TabIndex = 30;
            this.button_Clock_12.Text = "12";
            this.button_Clock_12.UseVisualStyleBackColor = true;
            this.button_Clock_12.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_11
            // 
            this.button_Clock_11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_11.Location = new System.Drawing.Point(524, 74);
            this.button_Clock_11.Name = "button_Clock_11";
            this.button_Clock_11.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_11.TabIndex = 29;
            this.button_Clock_11.Text = "11";
            this.button_Clock_11.UseVisualStyleBackColor = true;
            this.button_Clock_11.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_10
            // 
            this.button_Clock_10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_10.Location = new System.Drawing.Point(478, 74);
            this.button_Clock_10.Name = "button_Clock_10";
            this.button_Clock_10.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_10.TabIndex = 28;
            this.button_Clock_10.Text = "10";
            this.button_Clock_10.UseVisualStyleBackColor = true;
            this.button_Clock_10.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_9
            // 
            this.button_Clock_9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_9.Location = new System.Drawing.Point(432, 74);
            this.button_Clock_9.Name = "button_Clock_9";
            this.button_Clock_9.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_9.TabIndex = 27;
            this.button_Clock_9.Text = "9";
            this.button_Clock_9.UseVisualStyleBackColor = true;
            this.button_Clock_9.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_8
            // 
            this.button_Clock_8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_8.Location = new System.Drawing.Point(386, 74);
            this.button_Clock_8.Name = "button_Clock_8";
            this.button_Clock_8.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_8.TabIndex = 26;
            this.button_Clock_8.Text = "8";
            this.button_Clock_8.UseVisualStyleBackColor = true;
            this.button_Clock_8.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_7
            // 
            this.button_Clock_7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_7.Location = new System.Drawing.Point(340, 74);
            this.button_Clock_7.Name = "button_Clock_7";
            this.button_Clock_7.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_7.TabIndex = 25;
            this.button_Clock_7.Text = "7";
            this.button_Clock_7.UseVisualStyleBackColor = true;
            this.button_Clock_7.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_6
            // 
            this.button_Clock_6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_6.Location = new System.Drawing.Point(294, 74);
            this.button_Clock_6.Name = "button_Clock_6";
            this.button_Clock_6.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_6.TabIndex = 24;
            this.button_Clock_6.Text = "6";
            this.button_Clock_6.UseVisualStyleBackColor = true;
            this.button_Clock_6.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_5
            // 
            this.button_Clock_5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_5.Location = new System.Drawing.Point(248, 74);
            this.button_Clock_5.Name = "button_Clock_5";
            this.button_Clock_5.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_5.TabIndex = 23;
            this.button_Clock_5.Text = "5";
            this.button_Clock_5.UseVisualStyleBackColor = true;
            this.button_Clock_5.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_4
            // 
            this.button_Clock_4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_4.Location = new System.Drawing.Point(202, 74);
            this.button_Clock_4.Name = "button_Clock_4";
            this.button_Clock_4.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_4.TabIndex = 22;
            this.button_Clock_4.Text = "4";
            this.button_Clock_4.UseVisualStyleBackColor = true;
            this.button_Clock_4.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_3
            // 
            this.button_Clock_3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_3.Location = new System.Drawing.Point(156, 74);
            this.button_Clock_3.Name = "button_Clock_3";
            this.button_Clock_3.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_3.TabIndex = 21;
            this.button_Clock_3.Text = "3";
            this.button_Clock_3.UseVisualStyleBackColor = true;
            this.button_Clock_3.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_2
            // 
            this.button_Clock_2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_2.Location = new System.Drawing.Point(110, 74);
            this.button_Clock_2.Name = "button_Clock_2";
            this.button_Clock_2.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_2.TabIndex = 20;
            this.button_Clock_2.Text = "2";
            this.button_Clock_2.UseVisualStyleBackColor = true;
            this.button_Clock_2.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_1
            // 
            this.button_Clock_1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_1.Location = new System.Drawing.Point(64, 74);
            this.button_Clock_1.Name = "button_Clock_1";
            this.button_Clock_1.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_1.TabIndex = 19;
            this.button_Clock_1.Text = "1";
            this.button_Clock_1.UseVisualStyleBackColor = true;
            this.button_Clock_1.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // button_Clock_0
            // 
            this.button_Clock_0.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clock_0.Location = new System.Drawing.Point(18, 74);
            this.button_Clock_0.Name = "button_Clock_0";
            this.button_Clock_0.Size = new System.Drawing.Size(40, 23);
            this.button_Clock_0.TabIndex = 18;
            this.button_Clock_0.Text = "0";
            this.button_Clock_0.UseVisualStyleBackColor = true;
            this.button_Clock_0.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_3
            // 
            this.Clock_3.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_3;
            this.Clock_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_3.Location = new System.Drawing.Point(156, 28);
            this.Clock_3.Name = "Clock_3";
            this.Clock_3.Size = new System.Drawing.Size(40, 40);
            this.Clock_3.TabIndex = 3;
            this.Clock_3.UseVisualStyleBackColor = true;
            this.Clock_3.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_0
            // 
            this.Clock_0.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_0;
            this.Clock_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_0.Location = new System.Drawing.Point(18, 28);
            this.Clock_0.Name = "Clock_0";
            this.Clock_0.Size = new System.Drawing.Size(40, 40);
            this.Clock_0.TabIndex = 0;
            this.Clock_0.UseVisualStyleBackColor = true;
            this.Clock_0.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_16
            // 
            this.Clock_16.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_16;
            this.Clock_16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_16.Location = new System.Drawing.Point(754, 28);
            this.Clock_16.Name = "Clock_16";
            this.Clock_16.Size = new System.Drawing.Size(40, 40);
            this.Clock_16.TabIndex = 16;
            this.Clock_16.UseVisualStyleBackColor = true;
            this.Clock_16.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_1
            // 
            this.Clock_1.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_1;
            this.Clock_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_1.Location = new System.Drawing.Point(64, 28);
            this.Clock_1.Name = "Clock_1";
            this.Clock_1.Size = new System.Drawing.Size(40, 40);
            this.Clock_1.TabIndex = 1;
            this.Clock_1.UseVisualStyleBackColor = true;
            this.Clock_1.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_15
            // 
            this.Clock_15.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_15;
            this.Clock_15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_15.Location = new System.Drawing.Point(708, 28);
            this.Clock_15.Name = "Clock_15";
            this.Clock_15.Size = new System.Drawing.Size(40, 40);
            this.Clock_15.TabIndex = 15;
            this.Clock_15.UseVisualStyleBackColor = true;
            this.Clock_15.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_2
            // 
            this.Clock_2.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_2;
            this.Clock_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_2.Location = new System.Drawing.Point(110, 28);
            this.Clock_2.Name = "Clock_2";
            this.Clock_2.Size = new System.Drawing.Size(40, 40);
            this.Clock_2.TabIndex = 2;
            this.Clock_2.UseVisualStyleBackColor = true;
            this.Clock_2.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_14
            // 
            this.Clock_14.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_14;
            this.Clock_14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_14.Location = new System.Drawing.Point(662, 28);
            this.Clock_14.Name = "Clock_14";
            this.Clock_14.Size = new System.Drawing.Size(40, 40);
            this.Clock_14.TabIndex = 14;
            this.Clock_14.UseVisualStyleBackColor = true;
            this.Clock_14.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_4
            // 
            this.Clock_4.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_4;
            this.Clock_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_4.Location = new System.Drawing.Point(202, 28);
            this.Clock_4.Name = "Clock_4";
            this.Clock_4.Size = new System.Drawing.Size(40, 40);
            this.Clock_4.TabIndex = 4;
            this.Clock_4.UseVisualStyleBackColor = true;
            this.Clock_4.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_13
            // 
            this.Clock_13.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_13;
            this.Clock_13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_13.Location = new System.Drawing.Point(616, 28);
            this.Clock_13.Name = "Clock_13";
            this.Clock_13.Size = new System.Drawing.Size(40, 40);
            this.Clock_13.TabIndex = 13;
            this.Clock_13.UseVisualStyleBackColor = true;
            this.Clock_13.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_5
            // 
            this.Clock_5.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_5;
            this.Clock_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_5.Location = new System.Drawing.Point(248, 28);
            this.Clock_5.Name = "Clock_5";
            this.Clock_5.Size = new System.Drawing.Size(40, 40);
            this.Clock_5.TabIndex = 5;
            this.Clock_5.UseVisualStyleBackColor = true;
            this.Clock_5.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_12
            // 
            this.Clock_12.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_12;
            this.Clock_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_12.Location = new System.Drawing.Point(570, 28);
            this.Clock_12.Name = "Clock_12";
            this.Clock_12.Size = new System.Drawing.Size(40, 40);
            this.Clock_12.TabIndex = 12;
            this.Clock_12.UseVisualStyleBackColor = true;
            this.Clock_12.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_6
            // 
            this.Clock_6.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_6;
            this.Clock_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_6.Location = new System.Drawing.Point(294, 28);
            this.Clock_6.Name = "Clock_6";
            this.Clock_6.Size = new System.Drawing.Size(40, 40);
            this.Clock_6.TabIndex = 6;
            this.Clock_6.UseVisualStyleBackColor = true;
            this.Clock_6.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_11
            // 
            this.Clock_11.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_11;
            this.Clock_11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_11.Location = new System.Drawing.Point(524, 28);
            this.Clock_11.Name = "Clock_11";
            this.Clock_11.Size = new System.Drawing.Size(40, 40);
            this.Clock_11.TabIndex = 11;
            this.Clock_11.UseVisualStyleBackColor = true;
            this.Clock_11.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_7
            // 
            this.Clock_7.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_7;
            this.Clock_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_7.Location = new System.Drawing.Point(340, 28);
            this.Clock_7.Name = "Clock_7";
            this.Clock_7.Size = new System.Drawing.Size(40, 40);
            this.Clock_7.TabIndex = 7;
            this.Clock_7.UseVisualStyleBackColor = true;
            this.Clock_7.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_10
            // 
            this.Clock_10.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_10;
            this.Clock_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_10.Location = new System.Drawing.Point(478, 28);
            this.Clock_10.Name = "Clock_10";
            this.Clock_10.Size = new System.Drawing.Size(40, 40);
            this.Clock_10.TabIndex = 10;
            this.Clock_10.UseVisualStyleBackColor = true;
            this.Clock_10.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_8
            // 
            this.Clock_8.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_8;
            this.Clock_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_8.Location = new System.Drawing.Point(386, 28);
            this.Clock_8.Name = "Clock_8";
            this.Clock_8.Size = new System.Drawing.Size(40, 40);
            this.Clock_8.TabIndex = 8;
            this.Clock_8.UseVisualStyleBackColor = true;
            this.Clock_8.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Clock_9
            // 
            this.Clock_9.BackgroundImage = global::PokemonSunMoonRNGTool.Properties.Resources.pic_Clock_9;
            this.Clock_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clock_9.Location = new System.Drawing.Point(432, 28);
            this.Clock_9.Name = "Clock_9";
            this.Clock_9.Size = new System.Drawing.Size(40, 40);
            this.Clock_9.TabIndex = 9;
            this.Clock_9.UseVisualStyleBackColor = true;
            this.Clock_9.Click += new System.EventHandler(this.Get_Clock_Number);
            // 
            // Tab_Egg
            // 
            this.Tab_Egg.Controls.Add(this.tabControl1);
            this.Tab_Egg.Location = new System.Drawing.Point(4, 22);
            this.Tab_Egg.Name = "Tab_Egg";
            this.Tab_Egg.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Egg.Size = new System.Drawing.Size(1136, 538);
            this.Tab_Egg.TabIndex = 1;
            this.Tab_Egg.Text = "孵化乱数";
            this.Tab_Egg.UseVisualStyleBackColor = true;
            // 
            // Tab_ID
            // 
            this.Tab_ID.Controls.Add(this.ID_SearchSettings);
            this.Tab_ID.Controls.Add(this.ID_Search);
            this.Tab_ID.Controls.Add(this.ID_dataGridView);
            this.Tab_ID.Controls.Add(this.ID_Filters);
            this.Tab_ID.Controls.Add(this.ID_RNGInfo);
            this.Tab_ID.Location = new System.Drawing.Point(4, 22);
            this.Tab_ID.Name = "Tab_ID";
            this.Tab_ID.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_ID.Size = new System.Drawing.Size(1136, 538);
            this.Tab_ID.TabIndex = 3;
            this.Tab_ID.Text = "ID調整";
            this.Tab_ID.UseVisualStyleBackColor = true;
            // 
            // ID_SearchSettings
            // 
            this.ID_SearchSettings.Controls.Add(this.ID_L_CorrectionValue);
            this.ID_SearchSettings.Controls.Add(this.Clock_CorrectionValue);
            this.ID_SearchSettings.Location = new System.Drawing.Point(9, 390);
            this.ID_SearchSettings.Name = "ID_SearchSettings";
            this.ID_SearchSettings.Size = new System.Drawing.Size(323, 78);
            this.ID_SearchSettings.TabIndex = 62;
            this.ID_SearchSettings.TabStop = false;
            this.ID_SearchSettings.Text = "その他";
            // 
            // ID_L_CorrectionValue
            // 
            this.ID_L_CorrectionValue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_L_CorrectionValue.Location = new System.Drawing.Point(4, 29);
            this.ID_L_CorrectionValue.Name = "ID_L_CorrectionValue";
            this.ID_L_CorrectionValue.Size = new System.Drawing.Size(93, 42);
            this.ID_L_CorrectionValue.TabIndex = 84;
            this.ID_L_CorrectionValue.Text = "針の補正";
            this.ID_L_CorrectionValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Clock_CorrectionValue
            // 
            this.Clock_CorrectionValue.Font = new System.Drawing.Font("Consolas", 9F);
            this.Clock_CorrectionValue.Location = new System.Drawing.Point(109, 27);
            this.Clock_CorrectionValue.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.Clock_CorrectionValue.Name = "Clock_CorrectionValue";
            this.Clock_CorrectionValue.Size = new System.Drawing.Size(62, 22);
            this.Clock_CorrectionValue.TabIndex = 85;
            // 
            // ID_Search
            // 
            this.ID_Search.Location = new System.Drawing.Point(257, 474);
            this.ID_Search.Name = "ID_Search";
            this.ID_Search.Size = new System.Drawing.Size(75, 23);
            this.ID_Search.TabIndex = 61;
            this.ID_Search.Text = "計算";
            this.ID_Search.UseVisualStyleBackColor = true;
            this.ID_Search.Click += new System.EventHandler(this.ID_Search_Click);
            // 
            // ID_dataGridView
            // 
            this.ID_dataGridView.AllowUserToAddRows = false;
            this.ID_dataGridView.AllowUserToDeleteRows = false;
            this.ID_dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ID_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ID_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ID_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID_frame,
            this.dgvID_ID,
            this.dgvID_TSV,
            this.dgvID_TID,
            this.dgvID_SID,
            this.dgvID_Clock});
            this.ID_dataGridView.Location = new System.Drawing.Point(338, 6);
            this.ID_dataGridView.Name = "ID_dataGridView";
            this.ID_dataGridView.ReadOnly = true;
            this.ID_dataGridView.RowTemplate.Height = 21;
            this.ID_dataGridView.Size = new System.Drawing.Size(792, 526);
            this.ID_dataGridView.TabIndex = 3;
            // 
            // dgvID_frame
            // 
            this.dgvID_frame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvID_frame.HeaderText = "Frame";
            this.dgvID_frame.Name = "dgvID_frame";
            this.dgvID_frame.ReadOnly = true;
            this.dgvID_frame.Width = 62;
            // 
            // dgvID_ID
            // 
            this.dgvID_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvID_ID.HeaderText = "ID（通常）";
            this.dgvID_ID.Name = "dgvID_ID";
            this.dgvID_ID.ReadOnly = true;
            this.dgvID_ID.Width = 77;
            // 
            // dgvID_TSV
            // 
            this.dgvID_TSV.HeaderText = "TSV";
            this.dgvID_TSV.Name = "dgvID_TSV";
            this.dgvID_TSV.ReadOnly = true;
            this.dgvID_TSV.Width = 66;
            // 
            // dgvID_TID
            // 
            this.dgvID_TID.HeaderText = "TID";
            this.dgvID_TID.Name = "dgvID_TID";
            this.dgvID_TID.ReadOnly = true;
            this.dgvID_TID.Width = 60;
            // 
            // dgvID_SID
            // 
            this.dgvID_SID.HeaderText = "SID";
            this.dgvID_SID.Name = "dgvID_SID";
            this.dgvID_SID.ReadOnly = true;
            this.dgvID_SID.Width = 60;
            // 
            // dgvID_Clock
            // 
            this.dgvID_Clock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvID_Clock.HeaderText = "針";
            this.dgvID_Clock.Name = "dgvID_Clock";
            this.dgvID_Clock.ReadOnly = true;
            this.dgvID_Clock.Width = 42;
            // 
            // ID_Filters
            // 
            this.ID_Filters.Controls.Add(this.PartialMatch);
            this.ID_Filters.Controls.Add(this.PerfectMatching);
            this.ID_Filters.Controls.Add(this.ID_Invalid_Refine);
            this.ID_Filters.Controls.Add(this.ID_List);
            this.ID_Filters.Controls.Add(this.L_ID_List);
            this.ID_Filters.Controls.Add(this.ID_PSVList);
            this.ID_Filters.Controls.Add(this.ID_shiny);
            this.ID_Filters.Controls.Add(this.L_PSVList);
            this.ID_Filters.Location = new System.Drawing.Point(9, 112);
            this.ID_Filters.Name = "ID_Filters";
            this.ID_Filters.Size = new System.Drawing.Size(323, 272);
            this.ID_Filters.TabIndex = 2;
            this.ID_Filters.TabStop = false;
            this.ID_Filters.Text = "フィルター";
            // 
            // PartialMatch
            // 
            this.PartialMatch.AutoSize = true;
            this.PartialMatch.Location = new System.Drawing.Point(205, 54);
            this.PartialMatch.Name = "PartialMatch";
            this.PartialMatch.Size = new System.Drawing.Size(71, 16);
            this.PartialMatch.TabIndex = 110;
            this.PartialMatch.Text = "部分一致";
            this.PartialMatch.UseVisualStyleBackColor = true;
            // 
            // PerfectMatching
            // 
            this.PerfectMatching.AutoSize = true;
            this.PerfectMatching.Checked = true;
            this.PerfectMatching.Location = new System.Drawing.Point(205, 32);
            this.PerfectMatching.Name = "PerfectMatching";
            this.PerfectMatching.Size = new System.Drawing.Size(71, 16);
            this.PerfectMatching.TabIndex = 109;
            this.PerfectMatching.TabStop = true;
            this.PerfectMatching.Text = "完全一致";
            this.PerfectMatching.UseVisualStyleBackColor = true;
            // 
            // ID_Invalid_Refine
            // 
            this.ID_Invalid_Refine.AutoSize = true;
            this.ID_Invalid_Refine.Location = new System.Drawing.Point(205, 105);
            this.ID_Invalid_Refine.Name = "ID_Invalid_Refine";
            this.ID_Invalid_Refine.Size = new System.Drawing.Size(100, 16);
            this.ID_Invalid_Refine.TabIndex = 108;
            this.ID_Invalid_Refine.Text = "絞り込みを無効";
            this.ID_Invalid_Refine.UseVisualStyleBackColor = true;
            // 
            // ID_List
            // 
            this.ID_List.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_List.Location = new System.Drawing.Point(81, 30);
            this.ID_List.Multiline = true;
            this.ID_List.Name = "ID_List";
            this.ID_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ID_List.Size = new System.Drawing.Size(100, 91);
            this.ID_List.TabIndex = 106;
            // 
            // L_ID_List
            // 
            this.L_ID_List.AutoSize = true;
            this.L_ID_List.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ID_List.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.L_ID_List.Location = new System.Drawing.Point(19, 33);
            this.L_ID_List.Name = "L_ID_List";
            this.L_ID_List.Size = new System.Drawing.Size(56, 14);
            this.L_ID_List.TabIndex = 107;
            this.L_ID_List.Text = "ID List";
            // 
            // ID_PSVList
            // 
            this.ID_PSVList.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_PSVList.Location = new System.Drawing.Point(81, 156);
            this.ID_PSVList.Multiline = true;
            this.ID_PSVList.Name = "ID_PSVList";
            this.ID_PSVList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ID_PSVList.Size = new System.Drawing.Size(100, 91);
            this.ID_PSVList.TabIndex = 13;
            // 
            // ID_shiny
            // 
            this.ID_shiny.AutoSize = true;
            this.ID_shiny.Location = new System.Drawing.Point(205, 231);
            this.ID_shiny.Name = "ID_shiny";
            this.ID_shiny.Size = new System.Drawing.Size(103, 16);
            this.ID_shiny.TabIndex = 14;
            this.ID_shiny.Text = "色違いのみ出力";
            this.ID_shiny.UseVisualStyleBackColor = true;
            // 
            // L_PSVList
            // 
            this.L_PSVList.AutoSize = true;
            this.L_PSVList.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PSVList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.L_PSVList.Location = new System.Drawing.Point(11, 159);
            this.L_PSVList.Name = "L_PSVList";
            this.L_PSVList.Size = new System.Drawing.Size(64, 14);
            this.L_PSVList.TabIndex = 89;
            this.L_PSVList.Text = "PSV　List";
            // 
            // ID_RNGInfo
            // 
            this.ID_RNGInfo.Controls.Add(this.ID_L_InitialSeed);
            this.ID_RNGInfo.Controls.Add(this.label3);
            this.ID_RNGInfo.Controls.Add(this.ID_Frame);
            this.ID_RNGInfo.Controls.Add(this.label10);
            this.ID_RNGInfo.Controls.Add(this.ID_InitialSeed);
            this.ID_RNGInfo.Controls.Add(this.ID_min);
            this.ID_RNGInfo.Controls.Add(this.ID_max);
            this.ID_RNGInfo.Location = new System.Drawing.Point(6, 6);
            this.ID_RNGInfo.Name = "ID_RNGInfo";
            this.ID_RNGInfo.Size = new System.Drawing.Size(326, 100);
            this.ID_RNGInfo.TabIndex = 1;
            this.ID_RNGInfo.TabStop = false;
            this.ID_RNGInfo.Text = "検索範囲";
            // 
            // ID_L_InitialSeed
            // 
            this.ID_L_InitialSeed.Font = new System.Drawing.Font("Consolas", 9F);
            this.ID_L_InitialSeed.Location = new System.Drawing.Point(0, 29);
            this.ID_L_InitialSeed.Name = "ID_L_InitialSeed";
            this.ID_L_InitialSeed.Size = new System.Drawing.Size(80, 28);
            this.ID_L_InitialSeed.TabIndex = 72;
            this.ID_L_InitialSeed.Text = "初期seed";
            this.ID_L_InitialSeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 71;
            this.label3.Text = "0x";
            // 
            // ID_Frame
            // 
            this.ID_Frame.AutoSize = true;
            this.ID_Frame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Frame.Location = new System.Drawing.Point(58, 62);
            this.ID_Frame.Name = "ID_Frame";
            this.ID_Frame.Size = new System.Drawing.Size(42, 14);
            this.ID_Frame.TabIndex = 64;
            this.ID_Frame.Text = "Frame";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(198, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "～";
            // 
            // ID_InitialSeed
            // 
            this.ID_InitialSeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_InitialSeed.Hexadecimal = true;
            this.ID_InitialSeed.Location = new System.Drawing.Point(112, 27);
            this.ID_InitialSeed.Name = "ID_InitialSeed";
            this.ID_InitialSeed.Size = new System.Drawing.Size(80, 22);
            this.ID_InitialSeed.TabIndex = 1;
            // 
            // ID_min
            // 
            this.ID_min.Font = new System.Drawing.Font("Consolas", 9F);
            this.ID_min.Location = new System.Drawing.Point(112, 60);
            this.ID_min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ID_min.Name = "ID_min";
            this.ID_min.Size = new System.Drawing.Size(80, 22);
            this.ID_min.TabIndex = 2;
            this.ID_min.Value = new decimal(new int[] {
            1012,
            0,
            0,
            0});
            // 
            // ID_max
            // 
            this.ID_max.Font = new System.Drawing.Font("Consolas", 9F);
            this.ID_max.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ID_max.Location = new System.Drawing.Point(222, 60);
            this.ID_max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ID_max.Name = "ID_max";
            this.ID_max.Size = new System.Drawing.Size(80, 22);
            this.ID_max.TabIndex = 3;
            this.ID_max.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // other
            // 
            this.other.Location = new System.Drawing.Point(4, 22);
            this.other.Name = "other";
            this.other.Padding = new System.Windows.Forms.Padding(3);
            this.other.Size = new System.Drawing.Size(1136, 538);
            this.other.TabIndex = 2;
            this.other.Text = "その他";
            this.other.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 601);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1184, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon SunMoon RNG Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EggS_dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_parent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_parent6)).EndInit();
            this.GB_EggS_Parents_Info.ResumeLayout(false);
            this.GB_EggS_Parents_Info.PerformLayout();
            this.GB_EggS_RNGInfo.ResumeLayout(false);
            this.GB_EggS_RNGInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVlow1)).EndInit();
            this.GB_EggS_Filters.ResumeLayout(false);
            this.GB_EggS_Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IVup6)).EndInit();
            this.GB_EggS_SearchSettings.ResumeLayout(false);
            this.GB_EggS_SearchSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TSV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Tab_EggSearch.ResumeLayout(false);
            this.Tab_EggList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.L_dataGridView)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.L_RNGInfo.ResumeLayout(false);
            this.L_RNGInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Target_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_status3a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_status2a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_status1a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_status0a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_max)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.Tab_Stationary.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.Tab_StationarySearch.ResumeLayout(false);
            this.St_RNGInfo.ResumeLayout(false);
            this.St_RNGInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.St_InitialSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_TargetFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_TargetFrame_Range)).EndInit();
            this.St_SearchSettings.ResumeLayout(false);
            this.St_SearchSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.St_TSV)).EndInit();
            this.St_Filters.ResumeLayout(false);
            this.St_Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_stats1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_Lv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVlow6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_IVup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.St_dataGridView)).EndInit();
            this.Tab_StationaryClock.ResumeLayout(false);
            this.Calc_Frame_Info.ResumeLayout(false);
            this.Calc_Frame_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_InitialSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calc_max)).EndInit();
            this.Clock_RNGInfo.ResumeLayout(false);
            this.Clock_RNGInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_InitialSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_max)).EndInit();
            this.Clock_groupBox.ResumeLayout(false);
            this.Clock_groupBox.PerformLayout();
            this.Tab_Egg.ResumeLayout(false);
            this.Tab_ID.ResumeLayout(false);
            this.ID_SearchSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Clock_CorrectionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_dataGridView)).EndInit();
            this.ID_Filters.ResumeLayout(false);
            this.ID_Filters.PerformLayout();
            this.ID_RNGInfo.ResumeLayout(false);
            this.ID_RNGInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_InitialSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EggS_dataGridView;
        private System.Windows.Forms.Label L_EggS_post;
        private System.Windows.Forms.Label L_EggS_pre;
        private System.Windows.Forms.Label L_EggS_pre_H;
        private System.Windows.Forms.Label L_EggS_pre_A;
        private System.Windows.Forms.Label L_EggS_pre_B;
        private System.Windows.Forms.Label L_EggS_pre_C;
        private System.Windows.Forms.Label L_EggS_pre_D;
        private System.Windows.Forms.Label L_EggS_pre_S;
        private System.Windows.Forms.ComboBox pre_Items;
        private System.Windows.Forms.Label L_EggS_PreItems;
        private System.Windows.Forms.Label L_EggS_post_H;
        private System.Windows.Forms.Label L_EggS_post_A;
        private System.Windows.Forms.Label L_EggS_post_B;
        private System.Windows.Forms.Label L_EggS_post_C;
        private System.Windows.Forms.Label L_EggS_post_D;
        private System.Windows.Forms.Label L_EggS_post_S;
        private System.Windows.Forms.ComboBox post_Items;
        private System.Windows.Forms.Label L_EggS_PostItems;
        private System.Windows.Forms.GroupBox GB_EggS_Parents_Info;
        private System.Windows.Forms.CheckBox CB_EggS_International;
        private System.Windows.Forms.GroupBox GB_EggS_RNGInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label L_EggS_Range;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.NumericUpDown IVup2;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.NumericUpDown IVup3;
        private System.Windows.Forms.NumericUpDown IVup1;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.NumericUpDown IVup4;
        private System.Windows.Forms.NumericUpDown IVlow6;
        private System.Windows.Forms.NumericUpDown IVlow5;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.NumericUpDown IVlow4;
        private System.Windows.Forms.NumericUpDown IVup5;
        private System.Windows.Forms.NumericUpDown IVlow3;
        private System.Windows.Forms.NumericUpDown IVlow2;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.NumericUpDown IVlow1;
        private System.Windows.Forms.Label L_EggS_Search_H;
        private System.Windows.Forms.Label L_EggS_Search_A;
        private System.Windows.Forms.Label L_EggS_Search_B;
        private System.Windows.Forms.Label L_EggS_Search_C;
        private System.Windows.Forms.Label L_EggS_Search_D;
        private System.Windows.Forms.Label L_EggS_Search_S;
        private System.Windows.Forms.ComboBox mezapaType;
        private System.Windows.Forms.Label L_EggS_Search_HiddenPower;
        private System.Windows.Forms.Label L_EggS_Search_Ability;
        private System.Windows.Forms.ComboBox ability;
        private System.Windows.Forms.Label L_EggS_Search_Gender;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.GroupBox GB_EggS_Filters;
        private System.Windows.Forms.NumericUpDown IVup6;
        private System.Windows.Forms.Button B_EggS_Search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sex_ratio;
        private System.Windows.Forms.Label L_EggS_Gender_ratio;
        private System.Windows.Forms.CheckBox CB_EggS_ShinyCharm;
        private System.Windows.Forms.Label L_EggS_PostAbility;
        private System.Windows.Forms.ComboBox post_ability;
        private System.Windows.Forms.Label L_EggS_PreAbility;
        private System.Windows.Forms.ComboBox pre_ability;
        private System.Windows.Forms.CheckBox CB_EggS_post_ditto;
        private System.Windows.Forms.CheckBox CB_EggS_pre_ditto;
        private System.Windows.Forms.GroupBox GB_EggS_SearchSettings;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox CB_EggS_Shiny;
        private System.Windows.Forms.Label L_EggS_Search_Ball;
        private System.Windows.Forms.ComboBox ball;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_EggSearch;
        private System.Windows.Forms.TabPage Tab_EggList;
        private System.Windows.Forms.Button List_search;
        private System.Windows.Forms.DataGridView L_dataGridView;
        private System.Windows.Forms.GroupBox L_RNGInfo;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label L_eggrange;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.ToolStripMenuItem mnuSetEggSeed;
        private System.Windows.Forms.CheckBox L_TSV_shiny;
        private System.Windows.Forms.CheckBox CB_EggS_TSV_Shiny;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnu2Copy;
        private System.Windows.Forms.ToolStripMenuItem mnu2SelectAll;
        private System.Windows.Forms.CheckBox CB_EggS_Heterogeneity;
        private System.Windows.Forms.CheckBox CB_EggS_OtherTSV;
        private System.Windows.Forms.CheckBox CB_EggS_Search_DisableFilters;
        private System.Windows.Forms.NumericUpDown s_min;
        private System.Windows.Forms.NumericUpDown s_max;
        private System.Windows.Forms.NumericUpDown TSV;
        private System.Windows.Forms.NumericUpDown n_min;
        private System.Windows.Forms.NumericUpDown n_max;
        private HexNumericUpdown status0;
        private HexNumericUpdown status3;
        private HexNumericUpdown status2;
        private HexNumericUpdown status1;
        private HexNumericUpdown L_status3a;
        private HexNumericUpdown L_status2a;
        private HexNumericUpdown L_status1a;
        private HexNumericUpdown L_status0a;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Options;
        private System.Windows.Forms.ToolStripMenuItem Menu_TSV;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveConfig;
        private System.Windows.Forms.ToolStripMenuItem Menu_Language;
        private System.Windows.Forms.ToolStripComboBox CB_MainLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_used;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_seed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_ec;
	    private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_rand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_psv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvE_ability;
        private System.Windows.Forms.Label Repeat_times;
        private System.Windows.Forms.NumericUpDown Target_frame;
        private System.Windows.Forms.Label L_targetframe;
        private System.Windows.Forms.Label L_EggS_Search_Nature;
        private System.Windows.Forms.ComboBox nature;
        private System.Windows.Forms.ToolStripMenuItem mnuSetSearchSeed;
        private System.Windows.Forms.ToolStripMenuItem Menu_ParentsList;
        public System.Windows.Forms.NumericUpDown pre_parent1;
        public System.Windows.Forms.NumericUpDown pre_parent2;
        public System.Windows.Forms.NumericUpDown pre_parent3;
        public System.Windows.Forms.NumericUpDown pre_parent4;
        public System.Windows.Forms.NumericUpDown pre_parent5;
        public System.Windows.Forms.NumericUpDown pre_parent6;
        public System.Windows.Forms.NumericUpDown post_parent1;
        public System.Windows.Forms.NumericUpDown post_parent2;
        public System.Windows.Forms.NumericUpDown post_parent3;
        public System.Windows.Forms.NumericUpDown post_parent4;
        public System.Windows.Forms.NumericUpDown post_parent5;
        public System.Windows.Forms.NumericUpDown post_parent6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Tab_Stationary;
        private System.Windows.Forms.TabPage Tab_Egg;
        private System.Windows.Forms.GroupBox St_SearchSettings;
        private System.Windows.Forms.NumericUpDown St_TSV;
        private System.Windows.Forms.CheckBox St_shiny;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Stationary_List;
        private System.Windows.Forms.Button Stationary_Search;
        private System.Windows.Forms.GroupBox St_RNGInfo;
        private HexNumericUpdown St_InitialSeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button St_UpdateFrame;
        private System.Windows.Forms.Label St_L_TargetFrame;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label St_Frame;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label St_L_InitialSeed;
        private System.Windows.Forms.DataGridView St_dataGridView;
        private System.Windows.Forms.GroupBox St_Filters;
        private System.Windows.Forms.NumericUpDown St_stats1;
        private System.Windows.Forms.NumericUpDown St_stats5;
        private System.Windows.Forms.NumericUpDown St_stats6;
        private System.Windows.Forms.NumericUpDown St_stats4;
        private System.Windows.Forms.NumericUpDown St_stats3;
        private System.Windows.Forms.NumericUpDown St_stats2;
        private System.Windows.Forms.RadioButton St_search_Status;
        private System.Windows.Forms.Label L_St_search_S;
        private System.Windows.Forms.Label L_St_search_D;
        private System.Windows.Forms.RadioButton St_search_IV;
        private System.Windows.Forms.Label L_St_search_C;
        private System.Windows.Forms.Label L_St_search_B;
        private System.Windows.Forms.Label L_St_search_A;
        private System.Windows.Forms.Label L_St_search_H;
        private System.Windows.Forms.Label St_L_mezapa;
        private System.Windows.Forms.ComboBox St_pokedex;
        private System.Windows.Forms.Label St_Pokemon;
        private System.Windows.Forms.ComboBox St_mezapaType;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox St_Status_display;
        private System.Windows.Forms.NumericUpDown St_Lv;
        private System.Windows.Forms.NumericUpDown St_IVup6;
        private System.Windows.Forms.NumericUpDown St_IVlow1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown St_IVlow2;
        private System.Windows.Forms.ComboBox St_nature;
        private System.Windows.Forms.NumericUpDown St_IVlow3;
        private System.Windows.Forms.NumericUpDown St_IVup5;
        private System.Windows.Forms.NumericUpDown St_IVlow4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown St_IVlow5;
        private System.Windows.Forms.Label St_L_Nature;
        private System.Windows.Forms.NumericUpDown St_IVlow6;
        private System.Windows.Forms.NumericUpDown St_IVup4;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown St_IVup1;
        private System.Windows.Forms.NumericUpDown St_IVup3;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown St_IVup2;
        private System.Windows.Forms.CheckBox St_Invalid_Refine;
        private System.Windows.Forms.Label synchro_nature;
        private System.Windows.Forms.ComboBox St_Synchro_nature;
        private System.Windows.Forms.NumericUpDown St_min;
        private System.Windows.Forms.NumericUpDown St_max;
        private System.Windows.Forms.CheckBox AlwaysSynchro;
        private System.Windows.Forms.NumericUpDown St_TargetFrame;
        private System.Windows.Forms.NumericUpDown St_TargetFrame_Range;
        private System.Windows.Forms.TabPage other;
        private System.Windows.Forms.CheckBox St_SynchroOnly;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage Tab_StationarySearch;
        private System.Windows.Forms.TabPage Tab_StationaryClock;
        private System.Windows.Forms.Button Clock_16;
        private System.Windows.Forms.Button Clock_15;
        private System.Windows.Forms.Button Clock_14;
        private System.Windows.Forms.Button Clock_13;
        private System.Windows.Forms.Button Clock_12;
        private System.Windows.Forms.Button Clock_11;
        private System.Windows.Forms.Button Clock_10;
        private System.Windows.Forms.Button Clock_9;
        private System.Windows.Forms.Button Clock_8;
        private System.Windows.Forms.Button Clock_7;
        private System.Windows.Forms.Button Clock_6;
        private System.Windows.Forms.Button Clock_5;
        private System.Windows.Forms.Button Clock_4;
        private System.Windows.Forms.Button Clock_3;
        private System.Windows.Forms.Button Clock_2;
        private System.Windows.Forms.Button Clock_1;
        private System.Windows.Forms.Button Clock_0;
        private System.Windows.Forms.GroupBox Clock_groupBox;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button_Clock_16;
        private System.Windows.Forms.Button button_Clock_15;
        private System.Windows.Forms.Button button_Clock_14;
        private System.Windows.Forms.Button button_Clock_13;
        private System.Windows.Forms.Button button_Clock_12;
        private System.Windows.Forms.Button button_Clock_11;
        private System.Windows.Forms.Button button_Clock_10;
        private System.Windows.Forms.Button button_Clock_9;
        private System.Windows.Forms.Button button_Clock_8;
        private System.Windows.Forms.Button button_Clock_7;
        private System.Windows.Forms.Button button_Clock_6;
        private System.Windows.Forms.Button button_Clock_5;
        private System.Windows.Forms.Button button_Clock_4;
        private System.Windows.Forms.Button button_Clock_3;
        private System.Windows.Forms.Button button_Clock_2;
        private System.Windows.Forms.Button button_Clock_1;
        private System.Windows.Forms.Button button_Clock_0;
        private System.Windows.Forms.RadioButton clock_end;
        private System.Windows.Forms.RadioButton clock_begin;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Clock_List;
        private System.Windows.Forms.GroupBox Clock_RNGInfo;
        private System.Windows.Forms.Label St_Clocklist;
        private System.Windows.Forms.TextBox Clock_SearchList;
        private HexNumericUpdown Clock_InitialSeed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label St_Clock_Search_Frame;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label St_Clock_Search_InitialSeed;
        private System.Windows.Forms.NumericUpDown Clock_min;
        private System.Windows.Forms.NumericUpDown Clock_max;
        private System.Windows.Forms.Button Clock_CurrentFrame;
        private System.Windows.Forms.GroupBox Calc_Frame_Info;
        private System.Windows.Forms.Button Calc_Frame;
        private HexNumericUpdown Calc_InitialSeed;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label St_Clock_Time_Frame;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label St_Clock_Time_InitialSeed;
        private System.Windows.Forms.NumericUpDown Calc_min;
        private System.Windows.Forms.NumericUpDown Calc_max;
        private System.Windows.Forms.ListBox Search_Clock;
        private System.Windows.Forms.ListBox Calc_Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_tolerance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_Synchronize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_H_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_A_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_B_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_C_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_D_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_S_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_psv;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_Clock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSt_rand;
        private System.Windows.Forms.CheckBox Valid_Blink;
        private System.Windows.Forms.TextBox TB_Candidate_InitSeed;
        private System.Windows.Forms.Label L_Candidate_InitSeed;
        private System.Windows.Forms.NumericUpDown NPC;
        private System.Windows.Forms.Label qty_NPC;
        private System.Windows.Forms.TabPage Tab_ID;
        private System.Windows.Forms.DataGridView ID_dataGridView;
        private System.Windows.Forms.GroupBox ID_Filters;
        private System.Windows.Forms.TextBox ID_PSVList;
        private System.Windows.Forms.CheckBox ID_shiny;
        private System.Windows.Forms.Label L_PSVList;
        private System.Windows.Forms.GroupBox ID_RNGInfo;
        private System.Windows.Forms.Label ID_L_InitialSeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID_Frame;
        private System.Windows.Forms.Label label10;
        private HexNumericUpdown ID_InitialSeed;
        private System.Windows.Forms.NumericUpDown ID_min;
        private System.Windows.Forms.NumericUpDown ID_max;
        private System.Windows.Forms.Button ID_Search;
        private System.Windows.Forms.TextBox ID_List;
        private System.Windows.Forms.Label L_ID_List;
        private System.Windows.Forms.CheckBox ID_Invalid_Refine;
        private System.Windows.Forms.RadioButton PartialMatch;
        private System.Windows.Forms.RadioButton PerfectMatching;
        private System.Windows.Forms.GroupBox ID_SearchSettings;
        private System.Windows.Forms.Label ID_L_CorrectionValue;
        private System.Windows.Forms.NumericUpDown Clock_CorrectionValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID_frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID_TSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID_TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID_SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID_Clock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_Used;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_Seed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_Ability;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_Nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_PSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_EC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_EggS_Rand;
    }
}
