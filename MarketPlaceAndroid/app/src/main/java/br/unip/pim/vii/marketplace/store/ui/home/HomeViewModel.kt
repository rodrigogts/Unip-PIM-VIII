package br.unip.pim.vii.marketplace.store.ui.home

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class HomeViewModel : ViewModel() {

    private val _text = MutableLiveData<String>().apply {
        value = "Lista de produtos"
    }
    val text: LiveData<String> = _text

    val produtos: List<Produto> = listOf(
        Produto("Smartphone XYZ", "TechStore", 2499.00, "url_da_imagem_1"),
        Produto("Notebook Pro ABC", "CompuWorld", 5299.00, "url_da_imagem_2"),
        Produto("Tablet MaxiView 10\"", "QuickTech", 1999.00, "url_da_imagem_3"),
        Produto("Monitor UltraWide 27\"", "DisplayPros", 2200.00, "url_da_imagem_4"),
        Produto("Fones de Ouvido Bluetooth", "SoundMagic", 499.00, "url_da_imagem_5"),
        Produto("Mouse Gamer XYZ", "GamerTech", 150.00, "url_da_imagem_6"),
        Produto("Teclado Mecânico RGB", "KeyWorld", 350.00, "url_da_imagem_7"),
        Produto("Smartwatch FitPro", "HealthGear", 899.00, "url_da_imagem_8"),
        Produto("Carregador Portátil 10000mAh", "PowerPlus", 120.00, "url_da_imagem_9"),
        Produto("Câmera Digital ProShot", "PhotoMax", 2100.00, "url_da_imagem_10"),
        Produto("Webcam HD 1080p", "ClearView", 280.00, "url_da_imagem_11"),
        Produto("Drone Explorer Air", "FlyHigh", 4500.00, "url_da_imagem_12")
    )
}