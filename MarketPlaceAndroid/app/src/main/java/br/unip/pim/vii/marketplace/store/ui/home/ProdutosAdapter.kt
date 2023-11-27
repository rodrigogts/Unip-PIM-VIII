package br.unip.pim.vii.marketplace.store.ui.home
import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import br.unip.pim.vii.marketplace.store.databinding.ItemProdutoBinding

class ProdutosAdapter(private val produtos: List<Produto>) : RecyclerView.Adapter<ProdutosAdapter.ProdutoViewHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ProdutoViewHolder {
        val binding = ItemProdutoBinding.inflate(LayoutInflater.from(parent.context), parent, false)
        return ProdutoViewHolder(binding)
    }

    override fun onBindViewHolder(holder: ProdutoViewHolder, position: Int) {
        val produto = produtos[position]
        holder.bind(produto)
    }

    override fun getItemCount(): Int = produtos.size

    class ProdutoViewHolder(private val binding: ItemProdutoBinding) : RecyclerView.ViewHolder(binding.root) {
        fun bind(produto: Produto) {
            binding.textDescricao.text = produto.descricao
            binding.textVendedor.text = produto.vendedor
            binding.textPreco.text = String.format("R$ %.2f", produto.preco)
        }
    }
}