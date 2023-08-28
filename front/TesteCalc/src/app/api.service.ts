import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(private http: HttpClient) {}

  calcCDB(valor: number, prazo: number): Observable<any> {
    const url = 'https://localhost:7014/api/ApiCalc/calcularCDB'; 
    const params = { valor: valor.toString(), prazo: prazo.toString() };
    return this.http.get(url, { params });
  }
}
