#region License

// Copyright � 2008-2010 Northwestern University

// Authors:
// Vladimir Kleper
// Northwestern University
// Feinberg School of Medicine
// Department of Radiology
// Imaging Informatics Section
// Chicago, IL

// The Academic Free License v. 2.1

// This Academic Free License (the "License") applies to any original work of
// authorship (the "Original Work") whose owner (the "Licensor") has placed the
// following notice immediately following the copyright notice for the Original
// Work:

// Licensed under the Academic Free License version 2.1

// 1) Grant of Copyright License. Licensor hereby grants You a world-wide, royalty-
// free, non-exclusive, perpetual, sublicenseable license to do the following:

// a) to reproduce the Original Work in copies;

// b) to prepare derivative works ("Derivative Works") based upon the Original Work;

// c) to distribute copies of the Original Work and Derivative Works to the public;

// d) to perform the Original Work publicly; and

// e) to display the Original Work publicly.

// 2) Grant of Patent License. Licensor hereby grants You a world-wide, royalty-
// free, non-exclusive, perpetual, sublicenseable license, under patent claims
// owned or controlled by the Licensor that are embodied in the Original Work as
// furnished by the Licensor, to make, use, sell and offer for sale the Original
// Work and Derivative Works.

// 3) Grant of Source Code License. The term "Source Code" means the preferred form
// of the Original Work for making modifications to it and all available
// documentation describing how to modify the Original Work. Licensor hereby agrees
// to provide a machine-readable copy of the Source Code of the Original Work along
// with each copy of the Original Work that Licensor distributes. Licensor reserves
// the right to satisfy this obligation by placing a machine-readable copy of the
// Source Code in an information repository reasonably calculated to permit
// inexpensive and convenient access by You for as long as Licensor continues to
// distribute the Original Work, and by publishing the address of that information
// repository in a notice immediately following the copyright notice that applies
// to the Original Work.

// 4) Exclusions From License Grant. Neither the names of Licensor, nor the names
// of any contributors to the Original Work, nor any of their trademarks or service
// marks, may be used to endorse or promote products derived from this Original
// Work without express prior written permission of the Licensor. Nothing in this
// License shall be deemed to grant any rights to trademarks, copyrights, patents,
// trade secrets or any other intellectual property of Licensor except as expressly
// stated herein. No patent license is granted to make, use, sell or offer to sell
// embodiments of any patent claims other than the licensed claims defined in
// Section 2. No right is granted to the trademarks of Licensor even if such marks
// are included in the Original Work. Nothing in this License shall be interpreted
// to prohibit Licensor from licensing under different terms from this License any
// Original Work that Licensor otherwise would have a right to license.

// 5) This section intentionally omitted.

// 6) Attribution Rights. You must retain, in the Source Code of any Derivative
// Works that You create, all copyright, patent or trademark notices from the
// Source Code of the Original Work, as well as any notices of licensing and any
// descriptive text identified therein as an "Attribution Notice." You must cause
// the Source Code for any Derivative Works that You create to carry a prominent
// Attribution Notice reasonably calculated to inform recipients that You have
// modified the Original Work.

// 7) Warranty of Provenance and Disclaimer of Warranty. Licensor warrants that the
// copyright in and to the Original Work and the patent rights granted herein by
// Licensor are owned by the Licensor or are sublicensed to You under the terms of
// this License with the permission of the contributor(s) of those copyrights and
// patent rights. Except as expressly stated in the immediately proceeding
// sentence, the Original Work is provided under this License on an "AS IS" BASIS
// and WITHOUT WARRANTY, either express or implied, including, without limitation,
// the warranties of NON-INFRINGEMENT, MERCHANTABILITY or FITNESS FOR A PARTICULAR
// PURPOSE. THE ENTIRE RISK AS TO THE QUALITY OF THE ORIGINAL WORK IS WITH YOU.
// This DISCLAIMER OF WARRANTY constitutes an essential part of this License. No
// license to Original Work is granted hereunder except under this disclaimer.

// 8) Limitation of Liability. Under no circumstances and under no legal theory,
// whether in tort (including negligence), contract, or otherwise, shall the
// Licensor be liable to any person for any direct, indirect, special, incidental,
// or consequential damages of any character arising as a result of this License or
// the use of the Original Work including, without limitation, damages for loss of
// goodwill, work stoppage, computer failure or malfunction, or any and all other
// commercial damages or losses. This limitation of liability shall not apply to
// liability for death or personal injury resulting from Licensor's negligence to
// the extent applicable law prohibits such limitation. Some jurisdictions do not
// allow the exclusion or limitation of incidental or consequential damages, so
// this exclusion and limitation may not apply to You.

// 9) Acceptance and Termination. If You distribute copies of the Original Work or
// a Derivative Work, You must make a reasonable effort under the circumstances to
// obtain the express assent of recipients to the terms of this License. Nothing
// else but this License (or another written agreement between Licensor and You)
// grants You permission to create Derivative Works based upon the Original Work or
// to exercise any of the rights granted in Section 1 herein, and any attempt to do
// so except under the terms of this License (or another written agreement between
// Licensor and You) is expressly prohibited by U.S. copyright law, the equivalent
// laws of other countries, and by international treaty. Therefore, by exercising
// any of the rights granted to You in Section 1 herein, You indicate Your
// acceptance of this License and all of its terms and conditions.

// 10) Termination for Patent Action. This License shall terminate automatically
// and You may no longer exercise any of the rights granted to You by this License
// as of the date You commence an action, including a cross-claim or counterclaim,
// against Licensor or any licensee alleging that the Original Work infringes a
// patent. This termination provision shall not apply for an action alleging patent
// infringement by combinations of the Original Work with other software or 
// hardware.

// 11) Jurisdiction, Venue and Governing Law. Any action or suit relating to this
// License may be brought only in the courts of a jurisdiction wherein the Licensor
// resides or in which Licensor conducts its primary business, and under the laws
// of that jurisdiction excluding its conflict-of-law provisions. The application
// of the United Nations Convention on Contracts for the International Sale of
// Goods is expressly excluded. Any use of the Original Work outside the scope of
// this License or after its termination shall be subject to the requirements and
// penalties of the U.S. Copyright Act, 17 U.S.C. � 101 et seq., the equivalent
// laws of other countries, and international treaty. This section shall survive
// the termination of this License.

// 12) Attorneys Fees. In any action to enforce the terms of this License or
// seeking damages relating thereto, the prevailing party shall be entitled to
// recover its costs and expenses, including, without limitation, reasonable
// attorneys' fees and costs incurred in connection with such action, including any
// appeal of such action. This section shall survive the termination of this
// License.

// 13) Miscellaneous. This License represents the complete agreement concerning the
// subject matter hereof. If any provision of this License is held to be
// unenforceable, such provision shall be reformed only to the extent necessary to
// make it enforceable.

// 14) Definition of "You" in This License. "You" throughout this License, whether
// in upper or lower case, means an individual or a legal entity exercising rights
// under, and complying with all of the terms of, this License. For legal entities,
// "You" includes any entity that controls, is controlled by, or is under common
// control with you. For purposes of this definition, "control" means (i) the
// power, direct or indirect, to cause the direction or management of such entity,
// whether by contract or otherwise, or (ii) ownership of fifty percent (50%) or
// more of the outstanding shares, or (iii) beneficial ownership of such entity.

// 15) Right to Use. You may use the Original Work in all ways not otherwise
// restricted or conditioned by this License or by law, and Licensor promises not
// to interfere with or be responsible for such uses by You.

// This license is Copyright (C) 2003-2004 Lawrence E. Rosen. All rights reserved.
// Permission is hereby granted to copy and distribute this license without
// modification. This license may not be modified without the express written
// permission of its copyright owner.

#endregion

namespace AIM.Annotation.View.WinForms
{
    partial class StandardTemplateControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this._imagingObservation = new AIM.Annotation.View.WinForms.ImagingObservationCtrl();
			this._splitContainerBottom = new System.Windows.Forms.SplitContainer();
			this._splitContainerTop = new System.Windows.Forms.SplitContainer();
			this._anatomicEntity = new AIM.Annotation.View.WinForms.AnatomicEntityCtrl();
			this._lblCalculation = new System.Windows.Forms.Label();
			this._tboxCalculation = new System.Windows.Forms.TextBox();
			this._btnCreateAnnotation = new System.Windows.Forms.Button();
			this._btnUserInfo = new System.Windows.Forms.Button();
			this._tboxAnnotationName = new System.Windows.Forms.TextBox();
			this._lblAnnotationName = new System.Windows.Forms.Label();
			this._splitContainerBottom.Panel1.SuspendLayout();
			this._splitContainerBottom.Panel2.SuspendLayout();
			this._splitContainerBottom.SuspendLayout();
			this._splitContainerTop.Panel1.SuspendLayout();
			this._splitContainerTop.Panel2.SuspendLayout();
			this._splitContainerTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// _imagingObservation
			// 
			this._imagingObservation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._imagingObservation.DataSource = null;
			this._imagingObservation.Dock = System.Windows.Forms.DockStyle.Fill;
			this._imagingObservation.ImagingObsCharacteristicDataSource = null;
			this._imagingObservation.Location = new System.Drawing.Point(0, 0);
			this._imagingObservation.Margin = new System.Windows.Forms.Padding(0);
			this._imagingObservation.MinimumSize = new System.Drawing.Size(430, 70);
			this._imagingObservation.Name = "_imagingObservation";
			this._imagingObservation.Size = new System.Drawing.Size(438, 122);
			this._imagingObservation.TabIndex = 3;
			// 
			// _splitContainerBottom
			// 
			this._splitContainerBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._splitContainerBottom.Location = new System.Drawing.Point(3, 49);
			this._splitContainerBottom.Name = "_splitContainerBottom";
			this._splitContainerBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _splitContainerBottom.Panel1
			// 
			this._splitContainerBottom.Panel1.Controls.Add(this._splitContainerTop);
			// 
			// _splitContainerBottom.Panel2
			// 
			this._splitContainerBottom.Panel2.Controls.Add(this._lblCalculation);
			this._splitContainerBottom.Panel2.Controls.Add(this._tboxCalculation);
			this._splitContainerBottom.Size = new System.Drawing.Size(438, 388);
			this._splitContainerBottom.SplitterDistance = 228;
			this._splitContainerBottom.TabIndex = 19;
			// 
			// _splitContainerTop
			// 
			this._splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
			this._splitContainerTop.Location = new System.Drawing.Point(0, 0);
			this._splitContainerTop.Margin = new System.Windows.Forms.Padding(0);
			this._splitContainerTop.Name = "_splitContainerTop";
			this._splitContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _splitContainerTop.Panel1
			// 
			this._splitContainerTop.Panel1.Controls.Add(this._anatomicEntity);
			// 
			// _splitContainerTop.Panel2
			// 
			this._splitContainerTop.Panel2.Controls.Add(this._imagingObservation);
			this._splitContainerTop.Size = new System.Drawing.Size(438, 228);
			this._splitContainerTop.SplitterDistance = 102;
			this._splitContainerTop.TabIndex = 7;
			// 
			// _anatomicEntity
			// 
			this._anatomicEntity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._anatomicEntity.DataSource = null;
			this._anatomicEntity.Dock = System.Windows.Forms.DockStyle.Fill;
			this._anatomicEntity.Location = new System.Drawing.Point(0, 0);
			this._anatomicEntity.Margin = new System.Windows.Forms.Padding(0);
			this._anatomicEntity.Name = "_anatomicEntity";
			this._anatomicEntity.Size = new System.Drawing.Size(438, 102);
			this._anatomicEntity.TabIndex = 2;
			// 
			// _lblCalculation
			// 
			this._lblCalculation.AutoSize = true;
			this._lblCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this._lblCalculation.Location = new System.Drawing.Point(0, 0);
			this._lblCalculation.Margin = new System.Windows.Forms.Padding(2);
			this._lblCalculation.Name = "_lblCalculation";
			this._lblCalculation.Size = new System.Drawing.Size(97, 20);
			this._lblCalculation.TabIndex = 4;
			this._lblCalculation.Text = "Calculation:";
			this._lblCalculation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _tboxCalculation
			// 
			this._tboxCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._tboxCalculation.CausesValidation = false;
			this._tboxCalculation.Location = new System.Drawing.Point(4, 26);
			this._tboxCalculation.Margin = new System.Windows.Forms.Padding(4);
			this._tboxCalculation.Multiline = true;
			this._tboxCalculation.Name = "_tboxCalculation";
			this._tboxCalculation.ReadOnly = true;
			this._tboxCalculation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._tboxCalculation.Size = new System.Drawing.Size(430, 126);
			this._tboxCalculation.TabIndex = 5;
			// 
			// _btnCreateAnnotation
			// 
			this._btnCreateAnnotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnCreateAnnotation.Location = new System.Drawing.Point(11, 442);
			this._btnCreateAnnotation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this._btnCreateAnnotation.Name = "_btnCreateAnnotation";
			this._btnCreateAnnotation.Size = new System.Drawing.Size(155, 37);
			this._btnCreateAnnotation.TabIndex = 20;
			this._btnCreateAnnotation.Text = "&Create Annotation";
			this._btnCreateAnnotation.UseVisualStyleBackColor = true;
			this._btnCreateAnnotation.Click += new System.EventHandler(this._btnCreateAnnotation_Click);
			// 
			// _btnUserInfo
			// 
			this._btnUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnUserInfo.Location = new System.Drawing.Point(362, 443);
			this._btnUserInfo.Name = "_btnUserInfo";
			this._btnUserInfo.Size = new System.Drawing.Size(75, 36);
			this._btnUserInfo.TabIndex = 21;
			this._btnUserInfo.Text = "User Info";
			this._btnUserInfo.UseVisualStyleBackColor = true;
			this._btnUserInfo.Click += new System.EventHandler(this._btnUserInfo_Click);
			// 
			// _tboxAnnotationName
			// 
			this._tboxAnnotationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._tboxAnnotationName.BackColor = System.Drawing.Color.WhiteSmoke;
			this._tboxAnnotationName.Location = new System.Drawing.Point(3, 25);
			this._tboxAnnotationName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this._tboxAnnotationName.Name = "_tboxAnnotationName";
			this._tboxAnnotationName.Size = new System.Drawing.Size(438, 22);
			this._tboxAnnotationName.TabIndex = 18;
			// 
			// _lblAnnotationName
			// 
			this._lblAnnotationName.AutoSize = true;
			this._lblAnnotationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this._lblAnnotationName.Location = new System.Drawing.Point(3, 3);
			this._lblAnnotationName.Name = "_lblAnnotationName";
			this._lblAnnotationName.Size = new System.Drawing.Size(142, 20);
			this._lblAnnotationName.TabIndex = 17;
			this._lblAnnotationName.Text = "Annotation Name:";
			// 
			// StandardTemplateControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._splitContainerBottom);
			this.Controls.Add(this._btnCreateAnnotation);
			this.Controls.Add(this._btnUserInfo);
			this.Controls.Add(this._tboxAnnotationName);
			this.Controls.Add(this._lblAnnotationName);
			this.Name = "StandardTemplateControl";
			this.Size = new System.Drawing.Size(444, 482);
			this._splitContainerBottom.Panel1.ResumeLayout(false);
			this._splitContainerBottom.Panel2.ResumeLayout(false);
			this._splitContainerBottom.Panel2.PerformLayout();
			this._splitContainerBottom.ResumeLayout(false);
			this._splitContainerTop.Panel1.ResumeLayout(false);
			this._splitContainerTop.Panel2.ResumeLayout(false);
			this._splitContainerTop.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ImagingObservationCtrl _imagingObservation;
        private System.Windows.Forms.SplitContainer _splitContainerBottom;
        private System.Windows.Forms.SplitContainer _splitContainerTop;
        private AnatomicEntityCtrl _anatomicEntity;
        private System.Windows.Forms.Label _lblCalculation;
        private System.Windows.Forms.TextBox _tboxCalculation;
        private System.Windows.Forms.Button _btnCreateAnnotation;
        private System.Windows.Forms.Button _btnUserInfo;
        private System.Windows.Forms.TextBox _tboxAnnotationName;
        private System.Windows.Forms.Label _lblAnnotationName;

    }
}
