﻿namespace DXApplication1.Forms.Views.RentCarContextView {
    partial class RentCarContextView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarGroupViews = new DevExpress.XtraBars.Navigation.TileBarGroup();
                        
                        if(frmLogin.Role != Core.Enums.UserRole.Empleado)
                        {
                            this.tileBarItemRentCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                        }
                        if(frmLogin.Role != Core.Enums.UserRole.Vendedor)
                        {

                            this.tileBarItemBrandCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                            this.tileBarItemBrandModelCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                            this.tileBarItemVehicleCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                            this.tileBarItemFuelTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                            this.tileBarItemInspectionCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                            this.tileBarItemClientCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                            this.tileBarItemEmployeeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                            this.tileBarItemVehicleTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                            if (frmLogin.Role == Core.Enums.UserRole.SuperUser || frmLogin.Role == Core.Enums.UserRole.Admin)
                            {
                                this.tileBarItemUserCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
                            }
                        }
						            this.SuspendLayout();
			/// 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
			this.tileBar.AllowGlyphSkinning = true;
			this.tileBar.AllowSelectedItem = true;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.Groups.Add(this.tileBarGroupViews);
			this.tileBar.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
			this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.WideTileWidth = 150;
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
			this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
			this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.Text = "tileBar";
			//
			//tileBarGroupTables
			//
			this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
			// 
            // tileBarGroupViews
            // 
            this.tileBarGroupViews.Name = "tileBarGroupViews";
            this.tileBarGroupViews.Text = "VIEWS";
            //
            //tileBarItemRentCollectionView
            //
            if (frmLogin.Role != Core.Enums.UserRole.Empleado)
            {
                DevExpress.XtraEditors.TileItemElement tileItemElementRentCollectionView = new DevExpress.XtraEditors.TileItemElement();
                tileItemElementRentCollectionView.Text = "Rents";
                tileItemElementRentCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                this.tileBarItemRentCollectionView.Elements.Add(tileItemElementRentCollectionView);
                this.tileBarItemRentCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.tileBarItemRentCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                this.tileBarGroupTables.Items.Add(this.tileBarItemRentCollectionView);
            }

            if (frmLogin.Role != Core.Enums.UserRole.Vendedor)
            {
                //
                //tileBarItemBrandCollectionView
                //
                DevExpress.XtraEditors.TileItemElement tileItemElementBrandCollectionView = new DevExpress.XtraEditors.TileItemElement();
                tileItemElementBrandCollectionView.Text = "Brands";
                tileItemElementBrandCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                this.tileBarItemBrandCollectionView.Elements.Add(tileItemElementBrandCollectionView);
                this.tileBarItemBrandCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
                this.tileBarItemBrandCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                this.tileBarGroupTables.Items.Add(this.tileBarItemBrandCollectionView);
                //
                //tileBarItemBrandModelCollectionView
                //
                DevExpress.XtraEditors.TileItemElement tileItemElementBrandModelCollectionView = new DevExpress.XtraEditors.TileItemElement();
                tileItemElementBrandModelCollectionView.Text = "Brand Models";
                tileItemElementBrandModelCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                this.tileBarItemBrandModelCollectionView.Elements.Add(tileItemElementBrandModelCollectionView);
                this.tileBarItemBrandModelCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.tileBarItemBrandModelCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                this.tileBarGroupTables.Items.Add(this.tileBarItemBrandModelCollectionView);
                //
                //tileBarItemVehicleCollectionView
                //
                DevExpress.XtraEditors.TileItemElement tileItemElementVehicleCollectionView = new DevExpress.XtraEditors.TileItemElement();
                tileItemElementVehicleCollectionView.Text = "Vehicles";
                tileItemElementVehicleCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                this.tileBarItemVehicleCollectionView.Elements.Add(tileItemElementVehicleCollectionView);
                this.tileBarItemVehicleCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
                this.tileBarItemVehicleCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleCollectionView);
                //
                //tileBarItemFuelTypeCollectionView
                //
                DevExpress.XtraEditors.TileItemElement tileItemElementFuelTypeCollectionView = new DevExpress.XtraEditors.TileItemElement();
                tileItemElementFuelTypeCollectionView.Text = "Fuel Types";
                tileItemElementFuelTypeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                this.tileBarItemFuelTypeCollectionView.Elements.Add(tileItemElementFuelTypeCollectionView);
                this.tileBarItemFuelTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
                this.tileBarItemFuelTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                this.tileBarGroupTables.Items.Add(this.tileBarItemFuelTypeCollectionView);
                //
                //tileBarItemInspectionCollectionView
                //
                DevExpress.XtraEditors.TileItemElement tileItemElementInspectionCollectionView = new DevExpress.XtraEditors.TileItemElement();
                tileItemElementInspectionCollectionView.Text = "Inspections";
                tileItemElementInspectionCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                this.tileBarItemInspectionCollectionView.Elements.Add(tileItemElementInspectionCollectionView);
                this.tileBarItemInspectionCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
                this.tileBarItemInspectionCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                this.tileBarGroupTables.Items.Add(this.tileBarItemInspectionCollectionView);
                //
                //tileBarItemClientCollectionView
                //
                DevExpress.XtraEditors.TileItemElement tileItemElementClientCollectionView = new DevExpress.XtraEditors.TileItemElement();
                tileItemElementClientCollectionView.Text = "Clients";
                tileItemElementClientCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                this.tileBarItemClientCollectionView.Elements.Add(tileItemElementClientCollectionView);
                this.tileBarItemClientCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
                this.tileBarItemClientCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                this.tileBarGroupTables.Items.Add(this.tileBarItemClientCollectionView);
                //
                //tileBarItemEmployeeCollectionView
                //
                DevExpress.XtraEditors.TileItemElement tileItemElementEmployeeCollectionView = new DevExpress.XtraEditors.TileItemElement();
                tileItemElementEmployeeCollectionView.Text = "Employees";
                tileItemElementEmployeeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                this.tileBarItemEmployeeCollectionView.Elements.Add(tileItemElementEmployeeCollectionView);
                this.tileBarItemEmployeeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
                this.tileBarItemEmployeeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                this.tileBarGroupTables.Items.Add(this.tileBarItemEmployeeCollectionView);
                //
                //tileBarItemVehicleTypeCollectionView
                //
                DevExpress.XtraEditors.TileItemElement tileItemElementVehicleTypeCollectionView = new DevExpress.XtraEditors.TileItemElement();
                tileItemElementVehicleTypeCollectionView.Text = "Vehicle Types";
                tileItemElementVehicleTypeCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                this.tileBarItemVehicleTypeCollectionView.Elements.Add(tileItemElementVehicleTypeCollectionView);
                this.tileBarItemVehicleTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
                this.tileBarItemVehicleTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleTypeCollectionView);
                //
                //tileBarItemUserCollectionView
                //
                if (frmLogin.Role == Core.Enums.UserRole.SuperUser || frmLogin.Role == Core.Enums.UserRole.Admin)
                {
                    DevExpress.XtraEditors.TileItemElement tileItemElementUserCollectionView = new DevExpress.XtraEditors.TileItemElement();
                    tileItemElementUserCollectionView.Text = "Users";
                    tileItemElementUserCollectionView.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
                    this.tileBarItemUserCollectionView.Elements.Add(tileItemElementUserCollectionView);
                    this.tileBarItemUserCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
                    this.tileBarItemUserCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
                    this.tileBarGroupTables.Items.Add(this.tileBarItemUserCollectionView);
                }
            }		
				
			// 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.SelectedPage = null;
            this.navigationFrame.SelectedPageIndex = -1;
            this.navigationFrame.Text = "navigationFrame";
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DXApplication1.Forms.ViewModels.RentCarContextViewModel);
			// 
            // RentCarContextView
            // 
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "RentCarContextView";
			this.Text = "RentCarContextView";
            this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupViews;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemBrandCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemBrandModelCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemFuelTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemInspectionCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemClientCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemRentCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemEmployeeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemUserCollectionView;
					}
}
