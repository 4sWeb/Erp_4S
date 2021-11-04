import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { UnitesBasic_VM } from '../../../../models/BasicData/UnitesBasic_VM';
import { UniteBasicDataService } from '../../../../services/BasicData/UniteBasicData.service';
import { SharingDataService } from '../../../../services/SharingData/sharing-data.service';
import { DialogEditUnite } from '../unite-list/unite-list.component';

@Component({
  selector: 'app-unite-operation',
  templateUrl: './unite-operation.component.html',
  styleUrls: ['./unite-operation.component.css']
})

export class UniteOperationComponent implements OnInit {


  operationType: string;
  editeUnite: UnitesBasic_VM;
  Aname: string;
  Ename: string;
  SAName: string;
  SEName: string;
  constructor
    (
    private dialogRef: MatDialogRef<UniteOperationComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogEditUnite,
    public sharingData: SharingDataService,
    public UniteBasic: UniteBasicDataService
    )
  {
    this.operationType = this.sharingData.getOperationType();
    dialogRef.disableClose = true;

    this.editeUnite = data.editeUnite;
    this.Aname = this.editeUnite.Aname;
    this.Ename = this.editeUnite.Ename;
    this.SAName = this.editeUnite.Saname;
    this.SEName = this.editeUnite.Sename;
  }

  ngOnInit() {
  }

  updateUnite()
  {
    this.editeUnite.Aname = this.Aname;
    this.editeUnite.Ename = this.Ename;
    this.editeUnite.Saname = this.SAName;
    this.editeUnite.Sename = this.SEName;
    this.UniteBasic.UpdateUnitesBasic(this.editeUnite).subscribe
      (
        (res) =>
        {
          console.log("res", res);
        }
      );
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

}
