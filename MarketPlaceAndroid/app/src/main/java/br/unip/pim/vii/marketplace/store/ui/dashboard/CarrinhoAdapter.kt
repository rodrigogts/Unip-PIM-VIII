package br.unip.pim.vii.marketplace.store.ui.dashboard

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import br.unip.pim.vii.marketplace.store.databinding.ItemCarrinhoBinding
import br.unip.pim.vii.marketplace.store.ui.home.Produto

class CarrinhoAdapter(private val produtos: List<Produto>) : RecyclerView.Adapter<CarrinhoAdapter.CarrinhoViewHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): CarrinhoViewHolder {
        val binding = ItemCarrinhoBinding.inflate(LayoutInflater.from(parent.context), parent, false)
        return CarrinhoViewHolder(binding)
    }

    override fun onBindViewHolder(holder: CarrinhoViewHolder, position: Int) {
        val produto = produtos[position]
        holder.bind(produto)
    }

    override fun getItemCount(): Int = produtos.size

    class CarrinhoViewHolder(private val binding: ItemCarrinhoBinding) : RecyclerView.ViewHolder(binding.root) {
        fun bind(produto: Produto) {
            with(binding) {
                textDescricao.text = produto.descricao
                textVendedor.text = produto.vendedor
                textPreco.text = String.format("R$ %.2f", produto.preco)
            }
        }
    }
}
