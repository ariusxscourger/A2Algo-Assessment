import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InventoryService {
  private apiUrl = 'https://localhost:5001/api'; // Adjust to your backend API URL

  constructor(private http: HttpClient) { }

  // Products
  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(`${this.apiUrl}/products`);
  }

  addProduct(product: Product): Observable<Product> {
    return this.http.post<Product>(`${this.apiUrl}/products`, product);
  }

  updateProduct(product: Product): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/products/${product.id}`, product);
  }

  deleteProduct(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/products/${id}`);
  }

  // Sales
  recordSale(sale: Sale): Observable<Sale> {
    return this.http.post<Sale>(`${this.apiUrl}/sales`, sale);
  }

  // Purchases
  recordPurchase(purchase: Purchase): Observable<Purchase> {
    return this.http.post<Purchase>(`${this.apiUrl}/purchases`, purchase);
  }
}
