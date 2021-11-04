import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material';
import { ActivatedRoute } from '@angular/router';
import { Subject } from 'rxjs';
import { UnitesBasic_VM } from '../../../../models/BasicData/UnitesBasic_VM';
import { UniteBasicDataService } from '../../../../services/BasicData/UniteBasicData.service';
import { SharingDataService } from '../../../../services/SharingData/sharing-data.service';
import { UniteOperationComponent } from '../unite-operation/unite-operation.component';


//Dialog Edit interface
export interface DialogEditUnite {
  editeUnite: UnitesBasic_VM;
}

@Component({
  selector: 'app-unite-list',
  templateUrl: './unite-list.component.html',
  styleUrls: ['./unite-list.component.css']
})




export class UniteListComponent implements OnInit {

  dtOptions: DataTables.Settings = {};
  UniteBasic: UnitesBasic_VM;
  dtTrigger: Subject<any> = new Subject<any>();

  editUnite: UnitesBasic_VM;

  constructor
    (
    public ar: ActivatedRoute,
    public uniteService: UniteBasicDataService,
    public UniteoperationDialog: MatDialog,
    public sharingData: SharingDataService
    )

  {
    this.uniteService.GetAllUnites().subscribe
      (
        (res) =>
        {
          console.log("res",res);
          this.UniteBasic = res;
          console.log("this.UniteBasic", this.UniteBasic);
          this.dtTrigger.next();
        }
      )
  }

  ngOnInit() {
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 10
    };
  }

    //open UniteOperationComponent For Editing
  EditUnite(Editunite): void {
    this.sharingData.setOperationType("Edit");
    this.editUnite = Editunite;
    console.log(this.editUnite);
    const dialogReff = this.UniteoperationDialog.open(UniteOperationComponent, {

      width: '350px',
      data: { editeUnite: this.editUnite }
      });
      dialogReff.afterClosed().subscribe(result => {
        console.log('From unite list The operation unite dialog was closed', result);


        if (result == null) {
          result = this.editUnite;
        }

        return dialogReff.afterClosed();
      });

    };


  //open UniteOperationComponent For Editing
  AddUnite(): void {
    this.sharingData.setOperationType("Add");
    const dialogReff = this.UniteoperationDialog.open(UniteOperationComponent, {

      width: '350px',
     
    });
    dialogReff.afterClosed().subscribe(result => {
      console.log('From unite list The operation unite dialog was closed', result);


      return dialogReff.afterClosed();
    });

  };


  }


