<script>
    function sharePopup() {
        let compartir_popup = document.getElementsByClassName("compartir-popup");
        compartir_popup[0].classList.toggle('hidden');
    }
    function copyToClipboard() {
    var copyText = document.getElementById("content").value;
    navigator.clipboard.writeText(copyText).then(() => {
        sharePopup();
    });
  }
</script>