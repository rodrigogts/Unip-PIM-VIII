package br.unip.pim.vii.marketplace.store.ui.dashboard

import androidx.lifecycle.ViewModel
import br.unip.pim.vii.marketplace.store.ui.home.Produto

class DashboardViewModel : ViewModel() {

    val produtos: List<Produto> = listOf(
        Produto("Smartphone XYZ", "Eletrônicos ABC", 1999.99, "url_da_imagem_1"),
        Produto("Notebook Pro 15'", "Informática 123", 4999.99, "url_da_imagem_2"),
        Produto("Headphones Bluetooth", "Som & Acessórios", 299.99, "url_da_imagem_3")
    )
}
