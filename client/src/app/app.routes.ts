import { Routes } from '@angular/router';
import { HomeComponent } from './features/home/home.component';
import { ShopComponent } from './features/shop/shop.component';
import { ProductsDetailsComponent } from './features/shop/products-details/products-details.component';

export const routes: Routes = [
    {path: '', component: HomeComponent},
    {path: 'shop', component: ShopComponent},
    {path: 'shop/:id', component: ProductsDetailsComponent},
    {path: '**', redirectTo:"", pathMatch:'full'},

];
