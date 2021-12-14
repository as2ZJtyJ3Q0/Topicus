import { Component } from '@angular/core';
import { TopicusService } from './Services/topicus.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  medicineList: any;
  step = 1;
  selectedItem;
  deliveryMethod: string;
  prescription: string;
  constructor(private httpService: TopicusService) { }

  ngOnInit() {
    this.httpService.getMedicine().subscribe(
      (response) => {
        console.log(response)
        this.medicineList = response
      });
  }

  onMedicineChange(index) {
    this.selectedItem = (this.medicineList[index]);
  }
  onDeliveryMethodChanged(value){
    this.deliveryMethod = value;
  }
  onPrescriptionChanged(value){
    this.prescription = value;
  }

  getPackageType() {
    switch (this.selectedItem.PackageDetails.PackageType) {
      case PackageTypeEnum.Vials:
        return 'flesjes'
      case PackageTypeEnum.Strips:
        return 'strips'
      case PackageTypeEnum.Other:
        return 'andere verpakking'
    }
  }

  getFormType() {
    switch (this.selectedItem.Form) {
      case FormEnum.Powder:
        return 'poeder'
      case FormEnum.Tablet:
        return 'tabletten'
      case FormEnum.Liquid:
        return 'vloeistof'
    }
  }

  Back() {
    this.step--;
  }
  Next() {
    this.step++;
  }
}

enum FormEnum {
  Powder = 1,
  Tablet = 2,
  Liquid = 3
}

enum PackageTypeEnum {
  Vials = 1,
  Strips = 2,
  Other = 3
}