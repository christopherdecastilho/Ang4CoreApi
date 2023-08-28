import { Component } from '@angular/core';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-calc-cdb',
  templateUrl: './calc-cdb.component.html',
  styleUrls: ['./calc-cdb.component.css']
})
export class CalcCDBComponent {
 valor: number = 0;
  prazo: number = 0;
  resultado: any = null;

  constructor(private apiService: ApiService) {}

  calcCDB() {
    if (this.valor > 0 && this.prazo > 1) {
      this.apiService.calcCDB(this.valor, this.prazo).subscribe(
        (response: any) => {
          this.resultado = response;
        },
        (error: any) => {
          console.error('Erro:', error);
        }
      );
    }
  }
}
