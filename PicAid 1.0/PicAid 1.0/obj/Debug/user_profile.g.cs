﻿#pragma checksum "D:\PicAid 1.0\14-2-14\PicAid 1.0\PicAid 1.0\user_profile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CE391A6725550659626AA32D3569D245"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PicAid_1._0 {
    
    
    public partial class user_profile : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock mail_block;
        
        internal System.Windows.Controls.TextBlock name_block;
        
        internal System.Windows.Controls.TextBlock city_block;
        
        internal System.Windows.Controls.TextBlock gender_block;
        
        internal System.Windows.Controls.TextBlock mobile_block;
        
        internal System.Windows.Controls.TextBlock dob_block;
        
        internal Microsoft.Phone.Controls.ToggleSwitch tglBlood;
        
        internal System.Windows.Controls.StackPanel Donate_blood_stack;
        
        internal System.Windows.Controls.RadioButton APO;
        
        internal System.Windows.Controls.RadioButton BPO;
        
        internal System.Windows.Controls.RadioButton ABPO;
        
        internal System.Windows.Controls.RadioButton OPO;
        
        internal System.Windows.Controls.RadioButton ANAG;
        
        internal System.Windows.Controls.RadioButton BNAG;
        
        internal System.Windows.Controls.RadioButton ABNAG;
        
        internal System.Windows.Controls.RadioButton ONAG;
        
        internal Microsoft.Phone.Controls.ToggleSwitch tglOrgan;
        
        internal System.Windows.Controls.StackPanel Donate_organ_stack;
        
        internal System.Windows.Controls.ListBox lstOrganList;
        
        internal System.Windows.Controls.Button btn_save;
        
        internal Microsoft.Phone.Controls.ToggleSwitch tglPaientBlood;
        
        internal System.Windows.Controls.StackPanel Need_blood_stack;
        
        internal System.Windows.Controls.RadioButton NDAPO;
        
        internal System.Windows.Controls.RadioButton NDBPO;
        
        internal System.Windows.Controls.RadioButton NDABPO;
        
        internal System.Windows.Controls.RadioButton NDOPO;
        
        internal System.Windows.Controls.RadioButton NDANAG;
        
        internal System.Windows.Controls.RadioButton NDBNAG;
        
        internal System.Windows.Controls.RadioButton NDABNAG;
        
        internal System.Windows.Controls.RadioButton NDONAG;
        
        internal System.Windows.Controls.Button needbld_btn;
        
        internal Microsoft.Phone.Controls.ToggleSwitch tglPatientOrgan;
        
        internal System.Windows.Controls.StackPanel Need_Organ_stack;
        
        internal System.Windows.Controls.ListBox lstNeedOrganList;
        
        internal System.Windows.Controls.Button needorg_btn;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PicAid%201.0;component/user_profile.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.mail_block = ((System.Windows.Controls.TextBlock)(this.FindName("mail_block")));
            this.name_block = ((System.Windows.Controls.TextBlock)(this.FindName("name_block")));
            this.city_block = ((System.Windows.Controls.TextBlock)(this.FindName("city_block")));
            this.gender_block = ((System.Windows.Controls.TextBlock)(this.FindName("gender_block")));
            this.mobile_block = ((System.Windows.Controls.TextBlock)(this.FindName("mobile_block")));
            this.dob_block = ((System.Windows.Controls.TextBlock)(this.FindName("dob_block")));
            this.tglBlood = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("tglBlood")));
            this.Donate_blood_stack = ((System.Windows.Controls.StackPanel)(this.FindName("Donate_blood_stack")));
            this.APO = ((System.Windows.Controls.RadioButton)(this.FindName("APO")));
            this.BPO = ((System.Windows.Controls.RadioButton)(this.FindName("BPO")));
            this.ABPO = ((System.Windows.Controls.RadioButton)(this.FindName("ABPO")));
            this.OPO = ((System.Windows.Controls.RadioButton)(this.FindName("OPO")));
            this.ANAG = ((System.Windows.Controls.RadioButton)(this.FindName("ANAG")));
            this.BNAG = ((System.Windows.Controls.RadioButton)(this.FindName("BNAG")));
            this.ABNAG = ((System.Windows.Controls.RadioButton)(this.FindName("ABNAG")));
            this.ONAG = ((System.Windows.Controls.RadioButton)(this.FindName("ONAG")));
            this.tglOrgan = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("tglOrgan")));
            this.Donate_organ_stack = ((System.Windows.Controls.StackPanel)(this.FindName("Donate_organ_stack")));
            this.lstOrganList = ((System.Windows.Controls.ListBox)(this.FindName("lstOrganList")));
            this.btn_save = ((System.Windows.Controls.Button)(this.FindName("btn_save")));
            this.tglPaientBlood = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("tglPaientBlood")));
            this.Need_blood_stack = ((System.Windows.Controls.StackPanel)(this.FindName("Need_blood_stack")));
            this.NDAPO = ((System.Windows.Controls.RadioButton)(this.FindName("NDAPO")));
            this.NDBPO = ((System.Windows.Controls.RadioButton)(this.FindName("NDBPO")));
            this.NDABPO = ((System.Windows.Controls.RadioButton)(this.FindName("NDABPO")));
            this.NDOPO = ((System.Windows.Controls.RadioButton)(this.FindName("NDOPO")));
            this.NDANAG = ((System.Windows.Controls.RadioButton)(this.FindName("NDANAG")));
            this.NDBNAG = ((System.Windows.Controls.RadioButton)(this.FindName("NDBNAG")));
            this.NDABNAG = ((System.Windows.Controls.RadioButton)(this.FindName("NDABNAG")));
            this.NDONAG = ((System.Windows.Controls.RadioButton)(this.FindName("NDONAG")));
            this.needbld_btn = ((System.Windows.Controls.Button)(this.FindName("needbld_btn")));
            this.tglPatientOrgan = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("tglPatientOrgan")));
            this.Need_Organ_stack = ((System.Windows.Controls.StackPanel)(this.FindName("Need_Organ_stack")));
            this.lstNeedOrganList = ((System.Windows.Controls.ListBox)(this.FindName("lstNeedOrganList")));
            this.needorg_btn = ((System.Windows.Controls.Button)(this.FindName("needorg_btn")));
        }
    }
}

